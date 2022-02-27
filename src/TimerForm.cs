using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace devtime
{
    public partial class TimerForm : Form
    {
        private delegate int HookProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hmod, uint dwThreadId);
        [DllImport("user32.dll")]
        private static extern int CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hhk);

        private bool initialized = false;
        private bool closing = false;

        private string context;

        private long dayBaseTime = 0; // ms
        private long dayCurrentStartTime;

        private Thread timerThread;
        private bool timerThreadShouldStop;

        private string previousDate;
        private string currentDate;
        private string nextDate;

        private List<string> days; // yyyy-MM-dd days that are currently in the DaysList listbox
        private int todayIndex; // Index of today in the days list

        private Control[] mostControls; // The controls that will be disabled after clicking 'Start'
        private bool[] enableMostControls; // Stores which controls are enabled before clicking 'Start'

        // For the taskbar effects
        private Shell32.ITaskbarList3 taskbarList3;

        // For the key hook
        private IntPtr hHook;
        private HookProc hookProc;
        private bool hookInitialized = false;

        private enum TimerState {
            Start,
            Starting,
            Stop,
            Stopping
        }

        private TimerState timerState;

        public TimerForm()
        {
            InitializeComponent();

            days = new List<string>();

            timerState = TimerState.Start;

            //DaysList.Font = new Font(FontFamily.GenericMonospace, DaysList.Font.Size);

            // Controls which need to be disabled when clicking 'Start'
            mostControls = new Control[]
            {
                Menu,
                RefreshButton,
                EditButton,
                RemoveButton,
                AddButton,
                PreviousMonthButton,
                NextMonthButton,
                DaysList,
                ProjectGroup
            };
            enableMostControls = new bool[mostControls.Length];

            // Taskbar effects
            taskbarList3 = (Shell32.ITaskbarList3) new Shell32.TaskbarList();
            taskbarList3.HrInit();

            hookProc = new HookProc(KeyHookProc);

            if (!File.Exists(Config.configPath))
            {
                // Save defaults
                Config.Save();
            }
            else
            {
                Config.Load();
            }

            if(Config.startHotkey != Config.Hotkey.None || Config.stopHotkey != Config.Hotkey.None)
            {
                InitializeKeyHook();
            }
        }

        ~TimerForm()
        {
            DestroyKeyHook();

            // Keep the key hook delegate alive until the form is destroyed
            GC.KeepAlive(hookProc);
        }

        private void TimerForm_Shown(object sender, EventArgs e)
        {
            bool failed = false;

            do
            {
                try
                {
                    DB.Destroy();
                    DB.Init(); // Load the db file

                    failed = false;
                }
                catch (Exception ex)
                {
                    Error(string.Format("Failed to open or create database. It may be corrupted, or the path may be invalid. Make sure the database path points to a valid file.\n\n{0}", ex.ToString()));
                    failed = true;

                    // Let the user change the db file path
                    SettingsForm form = new SettingsForm();

                    form.StartPosition = FormStartPosition.Manual;
                    form.Left = Location.X + Size.Width / 2 - form.Size.Width / 2;
                    form.Top = Location.Y + Size.Height / 2 - form.Size.Height / 2;

                    if (form.ShowDialog() != DialogResult.OK)
                    {
                        Close();
                        return;
                    }

                    Config.Save();
                }

            } while (failed);

            ReloadContexts();
            OnSettingsChanged();

            initialized = true;
        }

        private void TimerForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                if (Config.minimizeToTray)
                {
                    Hide();
                    NotifyIcon.Visible = true;
                }
            }
        }

        private void InitializeKeyHook()
        {
            if (!hookInitialized)
            {
                // WH_KEYBOARD_LL
                hHook = SetWindowsHookEx(13, hookProc, Marshal.GetHINSTANCE(typeof(TimerForm).Module), 0);
                hookInitialized = true;
            }
        }

        private void DestroyKeyHook()
        {
            if(hookInitialized)
            {
                UnhookWindowsHookEx(hHook);
                hookInitialized = false;
            }
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
            UpdateTaskbar();
        }

        private void UpdateTaskbar()
        {
            if(timerState == TimerState.Start)
            {
                SetTaskbarColor(Config.stoppedTimerColor);
            }
            else
            {
                SetTaskbarColor(Config.runningTimerColor);
            }
        }

        private void SetTaskbarColor(Config.TaskbarColor color)
        {
            Shell32.TBPFLAG flag = Shell32.TBPFLAG.NOPROGRESS;

            switch (color)
            {
                case Config.TaskbarColor.None:
                    flag = Shell32.TBPFLAG.NOPROGRESS;
                    NotifyIcon.Icon = Properties.Resources.tray;
                    break;
                case Config.TaskbarColor.Green:
                    NotifyIcon.Icon = Properties.Resources.tray_green;
                    flag = Shell32.TBPFLAG.NORMAL;
                    break;
                case Config.TaskbarColor.Yellow:
                    NotifyIcon.Icon = Properties.Resources.tray_yellow;
                    flag = Shell32.TBPFLAG.PAUSED;
                    break;
                case Config.TaskbarColor.Red:
                    NotifyIcon.Icon = Properties.Resources.tray_red;
                    flag = Shell32.TBPFLAG.ERROR;
                    break;
            }

            taskbarList3.SetProgressValue(Handle, 1, 1);
            taskbarList3.SetProgressState(Handle, flag);
        }

        private void Start()
        {
            timerState = TimerState.Starting;
            StartButton.Enabled = false;

            SelectToday();

            timerThreadShouldStop = false;
            // A thread is used since we want to manually control it.
            timerThread = new Thread(TimerThreadRun);
            timerThread.Start();

            StartButton.Text = "Stop";
            StartButton.Image = Properties.Resources.stop;
            StartButton.Enabled = true;
            StartButton.Refresh();

            DisableMostControls();

            timerState = TimerState.Stop;

            UpdateTaskbar();
        }

        private void Stop()
        {
            timerState = TimerState.Stopping;
            StartButton.Enabled = false;

            long stopTime = DateTime.Now.Ticks;

            timerThreadShouldStop = true;

            // Don't block the main thread.
            // A task is used since we simply want to execute a function and don't need manual control over the thread.
            Task.Run(new Action(() =>
            {
                // Timer thread takes max 10ms to stop, so it's ok to block the task thread for a bit
                while (timerThread.IsAlive)
                {
                    Thread.Sleep(1);
                }

                timerState = TimerState.Start;

                dayBaseTime = DB.SelectLoggedTime(context, days[todayIndex]) * TimeSpan.TicksPerMillisecond;

                Invoke(new Action(() =>
                {
                    UpdateTimer((int)(dayBaseTime / TimeSpan.TicksPerMillisecond));

                    StartButton.Text = "Start";
                    StartButton.Image = Properties.Resources.start;
                    StartButton.Enabled = true;
                    StartButton.Refresh();

                    EnableMostControls();
                    UpdateTaskbar();
                }));

                if (Config.freeMemoryWhenStopping)
                {
                    GC.Collect();
                }

                // If the user wants to close the form, and everything was saved,
                // close it now.
                if(closing)
                {
                    Application.Exit();
                }
            }));
        }

        private void UpdateTimer(int ms)
        {
            long hours = ms / (1000 * 60 * 60);
            ms %= 3600000;

            long minutes = ms / (1000 * 60);
            ms %= 60000;

            long seconds = ms / 1000;
            ms %= 1000;

            UpdateTimer(hours, minutes, seconds, ms);
        }

        private void UpdateTimer(long hours, long minutes, long seconds, long ms)
        {
            TimerMainLabel.Text = string.Format("{0:D2}:{1:D2}", hours, minutes);
            TimerSecondaryLabel.Text = string.Format("{0:D2}.{1:D2}", seconds, ms / 10);

            TimerMainLabel.Refresh();
            TimerSecondaryLabel.Refresh();
        }

        private void TimerThreadRun()
        {
            long checkpoint = DateTime.Now.Ticks;

            long time;

            // Used to detect clock skews and day changes
            DateTime last = DateTime.Now;

            while(!timerThreadShouldStop)
            {
                DateTime current = DateTime.Now;

                if(last.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) != current.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture))
                {
                    // The day changed; save the old one, create the new one if needed, and switch to it
                    LogTime(dayBaseTime + last.Ticks - dayCurrentStartTime);

                    SelectToday();

                    checkpoint = current.Ticks;
                }
                else if(last > current)
                {
                    // Clock skew (e.g. daylight saving); save the current time and update the base time
                    // This way, the clock continues smoothly and doesn't get confused by the hour change
                    LogTime(dayBaseTime + last.Ticks - dayCurrentStartTime);

                    dayBaseTime = (dayBaseTime + last.Ticks - dayCurrentStartTime) * TimeSpan.TicksPerMillisecond;
                    dayCurrentStartTime = current.Ticks;

                    checkpoint = current.Ticks;
                }

                time = dayBaseTime + current.Ticks - dayCurrentStartTime;

                // Save CPU time if the window isn't focused
                if (!Config.disableDynamicGuiUpdates || ActiveForm == this)
                {
                    Invoke(new Action(() =>
                    {
                        UpdateTimer((int) (time / TimeSpan.TicksPerMillisecond));
                    }));
                }

                if((current.Ticks - checkpoint) / TimeSpan.TicksPerSecond >= Config.databaseUpdateFrequency)
                {
                    // Save the logged time periodically
                    LogTime(time);
                    checkpoint = current.Ticks;
                }

                last = current;

                Thread.Sleep(10);
            }

            // Save the logged time when the timer is stopped
            time = (dayBaseTime + DateTime.Now.Ticks - dayCurrentStartTime);
            LogTime(time);
        }

        private void LogTime(long ticks)
        {
            DB.UpdateEntryLoggedTime(context, days[todayIndex], ticks / TimeSpan.TicksPerMillisecond);
        }

        private void LoadContext(string ctx)
        {
            string lastContext = context;

            context = ctx;

            try
            {
                UpdateTimer(0);
                ReloadContext();
            }
            catch(Exception ex)
            {
                context = lastContext;

                try
                {
                    ReloadContext();
                }
                catch(Exception innerEx)
                {
                    Error(string.Format("Fatal error: failed to restore last project data from the database. Devtime will now quit to avoid breaking anything.\n\n{0}", innerEx.ToString()));
                    Application.Exit();
                }

                throw ex;
            }
        }

        private void ReloadContext()
        {
            try
            {
                previousDate = null;
                currentDate = null;
                nextDate = null;

                // Try to load the newest date. If there are no entries, show an empty listbox and the current month
                if (!LoadDay())
                {
                    MonthLabel.Text = DateToMonthString(DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                    MonthLabel.Refresh();
                }
            }
            catch(Exception ex)
            {
                Error(string.Format("Failed to load project data from the database.\nThe project table may be corrupted or may not have the expected structure.\n\n{0}", ex.ToString()));
                throw ex;
            }
        }

        // When loading for the first time, select the first available context.
        // When refreshing, try to keep the current context. If it doesn't exist anymore, select the first one.
        private void ReloadContexts(string preferredContext = null)
        {
            ContextComboBox.Items.Clear();

            List<string> contexts = DB.GetTables();

            for(int i = 0; i < contexts.Count; ++i)
            {
                ContextComboBox.Items.Add(contexts[i]);
            }

            ContextComboBox.Items.Add("Add new project...");

            if(ContextComboBox.Items.Count > 1)
            {
                int index = 0;
                if (preferredContext != null)
                {
                    int found = ContextComboBox.Items.IndexOf(preferredContext);

                    if(found != -1)
                    {
                        index = found;
                    }
                }

                ContextComboBox.SelectedIndex = index;
                LoadContext((string) ContextComboBox.Items[index]);

                StartButton.Enabled = true;
                StartButton.Refresh();
                UpdateContextButtons(true);
            }
            else
            {
                days.Clear();
                DaysList.Items.Clear();
                DaysList.Refresh();

                previousDate = null;
                currentDate = null;
                nextDate = null;

                StartButton.Enabled = false;
                StartButton.Refresh();

                UpdatePreviousMonthButton();
                UpdateNextMonthButton();
                UpdateLogWork();
                UpdateDayButtons(false);
                UpdateContextButtons(false);

                UpdateTimer(0);
            }

            UpdateLogWork();
        }

        // Returns false if there are no entries in the database, and true otherwise
        private bool LoadDay(string day = null)
        {
            DaysList.Items.Clear();
            days.Clear();

            if (day == null)
            {
                // Load the newest date implicitly
                day = DB.SelectNewestDate(context);

                // No entries in the database
                if (day == null)
                {
                    DaysList.Refresh();
                    UpdatePreviousMonthButton();
                    UpdateNextMonthButton();
                    UpdateLogWork();
                    UpdateDayButtons(false);
                    return false;
                }
            }

            UpdateDayButtons(true);

            // If the day matches the current date, we will just refresh the listbox
            // Otherwise, we update the previous and next dates
            if (day != currentDate)
            {
                if (day == previousDate)
                {
                    nextDate = currentDate;
                    currentDate = day;
                    previousDate = DB.SelectNewestDateBeforeMonth(context, day);
                }
                else if (day == nextDate)
                {
                    previousDate = currentDate;
                    currentDate = day;
                    nextDate = DB.SelectOldestDateAfterMonth(context, day);
                }
                else
                {
                    currentDate = day;
                    previousDate = DB.SelectNewestDateBeforeMonth(context, day);
                    nextDate = DB.SelectOldestDateAfterMonth(context, day);
                }

                UpdatePreviousMonthButton();
                UpdateNextMonthButton();
            }

            MonthLabel.Text = DateToMonthString(currentDate);

            List<string> dates = DB.SelectDatesInMonth(context, currentDate);

            if (dates == null)
            {
                DaysList.Refresh();
                MonthLabel.Refresh();
                UpdateLogWork();
                return true;
            }

            for (int i = 0; i < dates.Count; ++i)
            {
                DaysList.Items.Add(DateToDayString(dates[i]));
                days.Add(dates[i]);
            }

            DaysList.SelectedIndex = 0;

            OnSelectEntry(days[0]);

            DaysList.Refresh();
            MonthLabel.Refresh();

            UpdateLogWork();

            return true;
        }

        private void SelectToday()
        {
            DateTime now = DateTime.Now;
            string today = now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            if (!HasEntryForToday())
            {
                // Add the entry to the database, listbox and internal list.
                // Since today is the newest day in the current month, insert it at index 0.
                DB.InsertEntry(context, now);
                ReloadContext();
            }
            else if (currentDate.Substring(0, 7) != today.Substring(0, 7)) // yyyy-MM
            {
                // If the user is viewing another month, open the current month
                ReloadContext();
            }

            // Select the day in the listbox
            todayIndex = days.IndexOf(today);
            DaysList.SelectedIndex = todayIndex;

            int baseTime = DB.SelectLoggedTime(context, today);

            dayBaseTime = baseTime * TimeSpan.TicksPerMillisecond;
            dayCurrentStartTime = DateTime.Now.Ticks;
        }

        private void OnSelectEntry(string entry)
        {
            int time = DB.SelectLoggedTime(context, entry);

            UpdateTimer(time);
            UpdateLogWork();
        }

        private bool HasEntryForToday()
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            return DB.DateExists(context, today);
        }

        private string DateToDayString(string when)
        {
            DateTime date = DateTime.ParseExact(when, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            string name = date.DayOfWeek.ToString();

            if(date.Date == DateTime.Now.Date)
            {
                name = "Today";
            }
            else if(date.Date == DateTime.Now.AddDays(-1).Date)
            {
                name = "Yesterday";
            }
            else if (date.Date == DateTime.Now.AddDays(1).Date)
            {
                name = "Tomorrow";
            }

            return string.Format("{0:D2} - {1}", date.Day, name);
        }

        private string DateToMonthString(string when)
        {
            DateTime date = DateTime.ParseExact(when, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            return date.ToString("MMM yyyy", CultureInfo.InvariantCulture);
        }

        private void UpdatePreviousMonthButton()
        {
            UpdateMonthPageButton(PreviousMonthButton, previousDate);
        }

        private void UpdateNextMonthButton()
        {
            UpdateMonthPageButton(NextMonthButton, nextDate);
        }

        // If the date associated with the button is null, the button is disabled
        // Otherwise, it's enabled
        private void UpdateMonthPageButton(Button button, string date)
        {
            if (date == null)
            {
                if (button.Enabled == true)
                {
                    button.Enabled = false;
                    button.Refresh();
                }
            }
            else
            {
                if (button.Enabled == false)
                {
                    button.Enabled = true;
                    button.Refresh();
                }
            }
        }

        private bool HasLogFor(string date)
        {
            try
            {
                string log = DB.SelectLog(context, date);

                return !string.IsNullOrWhiteSpace(log);
            }
            catch(Exception)
            {
                return false;
            }
        }

        private void UpdateLogWork()
        {
            if (DaysList.SelectedIndex != -1)
            {
                string date = days[DaysList.SelectedIndex];

                if (HasLogFor(date))
                {
                    LogWorkButton.Image = Properties.Resources.log;
                    return;
                }
            }

            LogWorkButton.Image = Properties.Resources.log_warning;
            Menu.Refresh();
        }

        void UpdateDayButtons(bool enabled)
        {
            LogWorkButton.Enabled = enabled;
            RemoveButton.Enabled = enabled;
            EditButton.Enabled = enabled;

            Menu.Refresh();
            RemoveButton.Refresh();
            EditButton.Refresh();
        }

        void UpdateContextButtons(bool enabled)
        {
            StatsExportButton.Enabled = enabled;
            AddButton.Enabled = enabled;
            EditProjectButton.Enabled = enabled;

            Menu.Refresh();
            AddButton.Refresh();
            EditProjectButton.Refresh();
        }

        void DisableMostControls()
        {
            for(int i = 0; i < mostControls.Length; ++i)
            {
                enableMostControls[i] = mostControls[i].Enabled;
                mostControls[i].Enabled = false;
                mostControls[i].Refresh();
            }
        }

        void EnableMostControls()
        {
            for (int i = 0; i < mostControls.Length; ++i)
            {
                mostControls[i].Enabled = enableMostControls[i];
                mostControls[i].Refresh();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            switch(timerState)
            {
                case TimerState.Start:
                    Start();
                    break;
                case TimerState.Stop:
                    Stop();
                    break;
                default:
                    return;
            }
        }

        private void ConsoleButton_Click(object sender, EventArgs e)
        {
            ConsoleForm form = new ConsoleForm();

            form.StartPosition = FormStartPosition.Manual;
            form.Left = Location.X + Size.Width / 2 - form.Size.Width / 2;
            form.Top = Location.Y + Size.Height / 2 - form.Size.Height / 2;

            form.ShowDialog();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            string dbPath = Config.databasePath;

            bool failed = false;

            do
            {
                SettingsForm form = new SettingsForm();

                form.StartPosition = FormStartPosition.Manual;
                form.Left = Location.X + Size.Width / 2 - form.Size.Width / 2;
                form.Top = Location.Y + Size.Height / 2 - form.Size.Height / 2;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    OnSettingsChanged();

                    // Database path changed, or the database needs to be reloaded due to a load failure
                    if (Config.databasePath != dbPath || failed)
                    {
                        try
                        {
                            DB.Destroy();
                            DB.Init(); // Load the new db file

                            ReloadContexts();

                            failed = false;
                        }
                        catch (Exception ex)
                        {
                            Error(string.Format("Failed to open or create database. It may be corrupted, or the path may be invalid. Make sure the database path points to a valid file.\n\n{0}", ex.ToString()));
                            failed = true;
                        }
                    }
                }
                else
                {
                    break;
                }

            } while (failed);

            // Failed to load database, and the user closed the settings form
            if(failed)
            {
                Close();
            }
        }

        private void OnSettingsChanged()
        {
            Config.Save();
            UpdateTaskbar();

            if(Config.startHotkey == Config.Hotkey.None && Config.stopHotkey == Config.Hotkey.None)
            {
                DestroyKeyHook();
            }
            else
            {
                InitializeKeyHook();
            }
        }

        private void LogWorkButton_Click(object sender, EventArgs e)
        {
            if(DaysList.SelectedIndex == -1)
            {
                return;
            }

            string date = days[DaysList.SelectedIndex];

            LogWorkForm form = new LogWorkForm(DB.SelectLog(context, date), date);

            form.StartPosition = FormStartPosition.Manual;
            form.Left = Location.X + Size.Width / 2 - form.Size.Width / 2;
            form.Top = Location.Y + Size.Height / 2 - form.Size.Height / 2;

            if(form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DB.UpdateEntryLog(context, date, form.log);
                    UpdateLogWork();
                }
                catch(Exception ex)
                {
                    Error(string.Format("Failed to log work.\n\n{0}", ex.ToString()));
                }
            }
        }

        private void StatsExportButton_Click(object sender, EventArgs e)
        {
            StatsForm form = new StatsForm(context);

            form.StartPosition = FormStartPosition.Manual;
            form.Left = Location.X + Size.Width / 2 - form.Size.Width / 2;
            form.Top = Location.Y + Size.Height / 2 - form.Size.Height / 2;

            form.ShowDialog();
        }

        private void DaysList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initialized)
            {
                if (timerState == TimerState.Start)
                {
                    OnSelectEntry(days[((ListBox)sender).SelectedIndex]);
                }
            }
        }

        private void PreviousMonthButton_Click(object sender, EventArgs e)
        {
            LoadDay(previousDate);
        }

        private void NextMonthButton_Click(object sender, EventArgs e)
        {
            LoadDay(nextDate);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ReloadContexts(context);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEntryForm form = new AddEntryForm(context);

            form.StartPosition = FormStartPosition.Manual;
            form.Left = Location.X + Size.Width / 2 - form.Size.Width / 2;
            form.Top = Location.Y + Size.Height / 2 - form.Size.Height / 2;

            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DateTime formDate = form.date; // CS1690

                    DB.InsertEntry(context, formDate, form.loggedTime);
                    LoadDay(formDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                }
                catch(Exception ex)
                {
                    Error(string.Format("Failed to add entry to the database.\n\n{0}", ex.ToString()));
                }
            }
        }

        private void ContextComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Last item = "Add a new project..."
            if(ContextComboBox.SelectedIndex == ContextComboBox.Items.Count - 1)
            {
                AddContextForm form = new AddContextForm();

                form.StartPosition = FormStartPosition.Manual;
                form.Left = Location.X + Size.Width / 2 - form.Size.Width / 2;
                form.Top = Location.Y + Size.Height / 2 - form.Size.Height / 2;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DB.CreateContext(form.contextName);
                        ReloadContexts(form.contextName);
                        return;
                    }
                    catch(Exception ex)
                    {
                        Error(string.Format("Failed to create new project in the database.\n\n{0}", ex.ToString()));
                    }
                }

                ContextComboBox.SelectedIndex = ContextComboBox.Items.IndexOf(context);
            }
            else
            {
                try
                {
                    LoadContext((string)ContextComboBox.Items[ContextComboBox.SelectedIndex]);
                }
                catch(Exception)
                {
                    // Restore the original context
                    ContextComboBox.SelectedIndex = ContextComboBox.Items.IndexOf(context);
                }
            }
        }

        void Error(string msg)
        {
            MessageBox.Show(msg, "devtime error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(DaysList.SelectedIndex == -1)
            {
                return;
            }

            string entryDate = days[DaysList.SelectedIndex];

            if (DialogResult.Yes == MessageBox.Show(string.Format("Are you sure you want to delete the entry for {0}?", entryDate), "devtime warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) {
                try
                {
                    DB.DeleteEntry(context, entryDate);
                    ReloadContext();
                }
                catch(Exception ex)
                {
                    Error(string.Format("Failed to delete entry from the database.\n\n{0}", ex.ToString()));
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (DaysList.SelectedIndex == -1)
            {
                return;
            }

            string entryDate = days[DaysList.SelectedIndex];
            int loggedTime = DB.SelectLoggedTime(context, entryDate);

            EditEntryForm form = new EditEntryForm(loggedTime);

            form.StartPosition = FormStartPosition.Manual;
            form.Left = Location.X + Size.Width / 2 - form.Size.Width / 2;
            form.Top = Location.Y + Size.Height / 2 - form.Size.Height / 2;

            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DB.UpdateEntryLoggedTime(context, entryDate, form.loggedTime);
                    OnSelectEntry(entryDate); // Update the GUI timer value
                }
                catch (Exception ex)
                {
                    Error(string.Format("Failed to edit entry.\n\n{0}", ex.ToString()));
                }
            }
        }

        private void EditProjectButton_Click(object sender, EventArgs e)
        {
            if (ContextComboBox.SelectedIndex == -1)
            {
                return;
            }

            EditContextForm form = new EditContextForm(context);

            form.StartPosition = FormStartPosition.Manual;
            form.Left = Location.X + Size.Width / 2 - form.Size.Width / 2;
            form.Top = Location.Y + Size.Height / 2 - form.Size.Height / 2;

            switch (form.ShowDialog())
            {
                case DialogResult.OK:
                    try
                    {
                        if(context == form.contextName)
                        {
                            return;
                        }

                        DB.UpdateContextName(context, form.contextName);
                        context = form.contextName;
                        ReloadContexts(context);
                    }
                    catch (Exception ex)
                    {
                        Error(string.Format("Failed to edit entry.\n\n{0}", ex.ToString()));
                    }
                    break;

                case DialogResult.Abort: // Delete
                    try
                    {
                        DB.DeleteContext(context);
                        ReloadContexts();
                    }
                    catch (Exception ex)
                    {
                        Error(string.Format("Failed to delete context from the database.\n\n{0}", ex.ToString()));
                    }
                    break;
            }
        }

        private int KeyHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            int result = CallNextHookEx(hHook, nCode, wParam, lParam);

            int param = wParam.ToInt32();

            // Key press
            if(param == 0x100 || param == 0x104)
            {
                int key = Marshal.ReadInt32(lParam);

                switch (timerState)
                {
                    case TimerState.Start:
                        if (Config.startHotkey != Config.Hotkey.None && key == (int)Config.startHotkey)
                        {
                            Start();
                        }
                        break;
                    case TimerState.Stop:
                        if (Config.stopHotkey != Config.Hotkey.None && key == (int)Config.stopHotkey)
                        {
                            Stop();
                        }
                        break;
                }
            }

            return result;
        }

        private void TimerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(timerState == TimerState.Stop)
            {
                closing = true;
                Stop();

                e.Cancel = true;
            }
        }
    }
}
