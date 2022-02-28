using System;
using System.IO;
using System.Windows.Forms;

namespace devtime
{
    public static class Config
    {
        public enum TaskbarColor
        {
            None,
            Green,
            Yellow,
            Red
        }

        public enum Hotkey
        {
            None,
            F1             = Keys.F1,
            F2             = Keys.F2,
            F3             = Keys.F3,
            F4             = Keys.F4,
            F5             = Keys.F5,
            F6             = Keys.F6,
            F7             = Keys.F7,
            F8             = Keys.F8,
            F9             = Keys.F9,
            F10            = Keys.F10,
            F11            = Keys.F11,
            F12            = Keys.F12,
            MediaPlayPause = Keys.MediaPlayPause
        }

        public static string configPath = "devtime.ini";

        public static uint databaseUpdateFrequency = 300;
        public static string databasePath = "devtime.db";
        public static uint databaseExportBufferSize = 30;

        public static TaskbarColor stoppedTimerColor = TaskbarColor.None;
        public static TaskbarColor runningTimerColor = TaskbarColor.Green;

        public static bool minimizeToTray = false;

        public static Hotkey startHotkey = Hotkey.None;
        public static Hotkey stopHotkey = Hotkey.None;

        public static bool disableDynamicGuiUpdates = true;
        public static bool freeMemoryWhenStopping = false;

        public static void Save()
        {
            using(StreamWriter writer = new StreamWriter(configPath))
            {
                writer.WriteLine("DatabaseUpdateFrequency=" + databaseUpdateFrequency.ToString());
                writer.WriteLine("DatabasePath=" + databasePath);
                writer.WriteLine("DatabaseExportBufferSize=" + databaseExportBufferSize.ToString());

                writer.WriteLine("StoppedTimerColor=" + stoppedTimerColor.ToString());
                writer.WriteLine("RunningTimerColor=" + runningTimerColor.ToString());
                writer.WriteLine("MinimizeToTray=" + minimizeToTray.ToString());

                writer.WriteLine("StartHotkey=" + startHotkey.ToString());
                writer.WriteLine("StopHotkey=" + stopHotkey.ToString());

                writer.WriteLine("DisableDynamicGuiUpdates=" + disableDynamicGuiUpdates.ToString());
                writer.WriteLine("FreeMemoryWhenStopping=" + freeMemoryWhenStopping.ToString());
            }
        }

        public static void Load()
        {
            try
            {
                using (StreamReader reader = new StreamReader(configPath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            string key = "";
                            string value = "";

                            bool isValue = false;

                            for (int i = 0; i < line.Length; ++i)
                            {
                                if (line[i] == '=' && !isValue)
                                {
                                    isValue = true;
                                }
                                else
                                {
                                    if (isValue)
                                    {
                                        value += line[i];
                                    }
                                    else
                                    {
                                        key += line[i];
                                    }
                                }
                            }

                            switch (key)
                            {
                                case "DatabaseUpdateFrequency":
                                    databaseUpdateFrequency = uint.Parse(value);
                                    break;
                                case "DatabasePath":
                                    databasePath = value;
                                    break;
                                case "DatabaseExportBufferSize":
                                    databaseExportBufferSize = uint.Parse(value);
                                    break;
                                case "StoppedTimerColor":
                                    stoppedTimerColor = (TaskbarColor)Enum.Parse(typeof(TaskbarColor), value);
                                    break;
                                case "RunningTimerColor":
                                    runningTimerColor = (TaskbarColor)Enum.Parse(typeof(TaskbarColor), value);
                                    break;
                                case "MinimizeToTray":
                                    minimizeToTray = bool.Parse(value);
                                    break;
                                case "StartHotkey":
                                    startHotkey = (Hotkey)Enum.Parse(typeof(Hotkey), value);
                                    break;
                                case "StopHotkey":
                                    stopHotkey = (Hotkey)Enum.Parse(typeof(Hotkey), value);
                                    break;
                                case "DisableDynamicGuiUpdates":
                                    disableDynamicGuiUpdates = bool.Parse(value);
                                    break;
                                case "FreeMemoryWhenStopping":
                                    freeMemoryWhenStopping = bool.Parse(value);
                                    break;
                            }
                        }
                        catch (Exception) { }
                    }
                }
            } catch(Exception) { }
        }
    }
}
