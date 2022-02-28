using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace devtime
{
    public static class DB
    {
        private static SQLite.DB instance = null;

        public static class Queries
        {
            // {0} - the context (e.g. 'work', 'myProject' etc)
            public const string CREATE_TABLE = "CREATE TABLE \"{0}\"(date TEXT PRIMARY KEY NOT NULL, logged_time INTEGER, log TEXT);";
            public const string INSERT_ENTRY = "INSERT INTO \"{0}\"(date, logged_time, log) VALUES(?, ?, ?);";
            public const string DELETE_CONTEXT = "DROP TABLE \"{0}\";";
            public const string DELETE_ENTRY = "DELETE FROM \"{0}\" WHERE date = ?;";
            public const string UPDATE_CONTEXT_NAME = "ALTER TABLE \"{0}\" RENAME TO \"{1}\";";
            public const string UPDATE_ENTRY_LOGGED_TIME = "UPDATE \"{0}\" SET logged_time = ? WHERE date = ?;";
            public const string UPDATE_ENTRY_LOG = "UPDATE \"{0}\" SET log = ? WHERE date = ?;";
            public const string SELECT_NEWEST_DATE = "SELECT date FROM \"{0}\" ORDER BY date DESC LIMIT 1;";
            public const string SELECT_OLDEST_DATE = "SELECT date FROM \"{0}\" ORDER BY date ASC LIMIT 1;";
            public const string SELECT_NEWEST_DATE_BEFORE_MONTH = "SELECT date FROM \"{0}\" WHERE substr(date, 1, 7) < ? ORDER BY date DESC LIMIT 1;";
            public const string SELECT_OLDEST_DATE_AFTER_MONTH = "SELECT date FROM \"{0}\" WHERE substr(date, 1, 7) > ? ORDER BY date ASC LIMIT 1;";
            public const string SELECT_DATES_IN_MONTH = "SELECT date FROM \"{0}\" WHERE substr(date, 1, 7) = ? ORDER BY date DESC"; // Dates will be in descending order in the list
            public const string SELECT_ENTRY_LOGGED_TIME = "SELECT logged_time FROM \"{0}\" WHERE date = ?;";
            public const string SELECT_ENTRY_LOG = "SELECT log FROM \"{0}\" WHERE date = ?;";
            public const string SELECT_ENTRY_COUNT = "SELECT COUNT(*) FROM \"{0}\" WHERE date = ?;"; // 0 if date doesn't exist, 1 otherwise
            public const string SELECT_TOTAL_LOGGED_TIME = "SELECT SUM(logged_time) FROM \"{0}\" WHERE date >= ? AND date <= ?;";
            public const string SELECT_TOTAL_ENTRY_COUNT = "SELECT COUNT(*) FROM \"{0}\" WHERE date >= ? AND date <= ?;";
            public const string SELECT_ENTRIES = "SELECT date, logged_time, log FROM \"{0}\" WHERE date >= ? AND date <= ? ORDER BY date ASC LIMIT ? OFFSET ?;";
        }

        public static void Init()
        {
            instance = new SQLite.DB(Config.databasePath);
        }

        public static void Destroy()
        {
            if (instance != null)
            {
                instance.Destroy();
            }
        }

        public static SQLite.DB.Statement CreateStatement(string query)
        {
            return instance.CreateStatement(query);
        }

        public static SQLite.DB.Statement CreateStatementInContext(string query, string context)
        {
            return instance.CreateStatement(string.Format(query, context));
        }

        public static SQLite.Column[] Exec(string query)
        {
            SQLite.DB.Statement statement = instance.CreateStatement(query);

            return statement.Exec();
        }

        public static SQLite.Column[] ExecInContext(string query, string context)
        {
            return Exec(string.Format(query, context));
        }

        public static List<string> GetTables()
        {
            SQLite.Column[] result = Exec("SELECT name FROM sqlite_master WHERE type='table' ORDER BY name ASC;");

            if(result == null)
            {
                return new List<string>();
            }

            return result[0].values.Cast<string>().ToList();
        }

        public static void CreateContext(string context)
        {
            ExecInContext(Queries.CREATE_TABLE, context);
        }

        public static void InsertEntry(string context, DateTime when, int loggedTime = 0)
        {
            string date = when.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            SQLite.DB.Statement stmt = CreateStatementInContext(Queries.INSERT_ENTRY, context);
            stmt.BindString(1, date);
            stmt.BindInt(2, loggedTime);
            stmt.BindNull(3);

            stmt.Exec();
        }

        public static void DeleteContext(string context)
        {
            SQLite.DB.Statement stmt = CreateStatementInContext(Queries.DELETE_CONTEXT, context);

            stmt.Exec();
        }

        public static void DeleteEntry(string context, string when)
        {
            SQLite.DB.Statement stmt = CreateStatementInContext(Queries.DELETE_ENTRY, context);
            stmt.BindString(1, when);

            stmt.Exec();
        }

        public static void UpdateContextName(string context, string newName)
        {
            SQLite.DB.Statement stmt = instance.CreateStatement(string.Format(Queries.UPDATE_CONTEXT_NAME, context, newName));

            stmt.Exec();
        }

        public static void UpdateEntryLoggedTime(string context, string when, long time)
        {
            SQLite.DB.Statement stmt = CreateStatementInContext(Queries.UPDATE_ENTRY_LOGGED_TIME, context);
            stmt.BindLong(1, time);
            stmt.BindString(2, when);

            stmt.Exec();
        }

        public static void UpdateEntryLog(string context, string when, string log)
        {
            SQLite.DB.Statement stmt = CreateStatementInContext(Queries.UPDATE_ENTRY_LOG, context);
            stmt.BindString(1, log);
            stmt.BindString(2, when);

            stmt.Exec();
        }

        public static string SelectNewestDate(string context)
        {
            SQLite.Column[] result = ExecInContext(Queries.SELECT_NEWEST_DATE, context);

            if(result == null)
            {
                return null;
            }

            return (string) result[0].values[0];
        }

        public static string SelectOldestDate(string context)
        {
            SQLite.Column[] result = ExecInContext(Queries.SELECT_OLDEST_DATE, context);

            if (result == null)
            {
                return null;
            }

            return (string)result[0].values[0];
        }

        public static string SelectNewestDateBeforeMonth(string context, string when)
        {
            string date = when.Substring(0, 7); // yyyy-MM

            SQLite.DB.Statement stmt = CreateStatementInContext(Queries.SELECT_NEWEST_DATE_BEFORE_MONTH, context);
            stmt.BindString(1, date);

            SQLite.Column[] result = stmt.Exec();

            if(result == null)
            {
                return null;
            }

            return (string) result[0].values[0];
        }

        public static string SelectOldestDateAfterMonth(string context, string when)
        {
            string date = when.Substring(0, 7); // yyyy-MM

            SQLite.DB.Statement stmt = CreateStatementInContext(Queries.SELECT_OLDEST_DATE_AFTER_MONTH, context);
            stmt.BindString(1, date);

            SQLite.Column[] result = stmt.Exec();

            if (result == null)
            {
                return null;
            }

            return (string)result[0].values[0];
        }

        public static List<string> SelectDatesInMonth(string context, string when)
        {
            string date = when.Substring(0, 7); // yyyy-MM

            SQLite.DB.Statement stmt = CreateStatementInContext(Queries.SELECT_DATES_IN_MONTH, context);
            stmt.BindString(1, date);

            SQLite.Column[] result = stmt.Exec();

            if (result == null)
            {
                return null;
            }

            return result[0].values.Cast<string>().ToList();
        }

        public static int SelectLoggedTime(string context, string when)
        {
            SQLite.DB.Statement stmt = CreateStatementInContext(Queries.SELECT_ENTRY_LOGGED_TIME, context);
            stmt.BindString(1, when);

            SQLite.Column[] result = stmt.Exec();

            if(result == null)
            {
                throw new NullReferenceException("No logged time found in the database");
            }

            return (int) (long) result[0].values[0];
        }

        public static string SelectLog(string context, string when)
        {
            SQLite.DB.Statement stmt = CreateStatementInContext(Queries.SELECT_ENTRY_LOG, context);
            stmt.BindString(1, when);

            SQLite.Column[] result = stmt.Exec();

            if (result == null)
            {
                throw new NullReferenceException("No log found in the database");
            }

            if(result[0].values.Count == 0)
            {
                return null;
            }

            return (string) result[0].values[0];
        }

        public static long SelectTotalLoggedTime(string context, string from, string to)
        {
            SQLite.DB.Statement stmt = CreateStatementInContext(Queries.SELECT_TOTAL_LOGGED_TIME, context);
            stmt.BindString(1, from);
            stmt.BindString(2, to);

            SQLite.Column[] result = stmt.Exec();

            if (result == null)
            {
                throw new NullReferenceException("No sum returned");
            }

            return (long) result[0].values[0];
        }

        public static long SelectTotalEntryCount(string context, string from, string to)
        {
            SQLite.DB.Statement stmt = CreateStatementInContext(Queries.SELECT_TOTAL_ENTRY_COUNT, context);
            stmt.BindString(1, from);
            stmt.BindString(2, to);

            SQLite.Column[] result = stmt.Exec();

            if (result == null)
            {
                throw new NullReferenceException("No count returned");
            }

            return (long)result[0].values[0];
        }

        public static SQLite.Column[] SelectEntries(string context, string from, string to, long offset, long count)
        {
            SQLite.DB.Statement stmt = CreateStatementInContext(Queries.SELECT_ENTRIES, context);
            stmt.BindString(1, from);
            stmt.BindString(2, to);
            stmt.BindLong(3, count);
            stmt.BindLong(4, offset);

            SQLite.Column[] result = stmt.Exec();

            if (result == null)
            {
                throw new NullReferenceException("No entries");
            }

            return result;
        }

        public static bool DateExists(string context, string when)
        {
            SQLite.DB.Statement stmt = CreateStatementInContext(Queries.SELECT_ENTRY_COUNT, context);
            stmt.BindString(1, when);

            SQLite.Column[] result = stmt.Exec();

            return result != null && (((long) result[0].values[0]) == 1);
        }
    }
}
