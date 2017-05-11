using System;

namespace DatabaseApp
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; private set; }

        public DbConnection (string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                ConnectionString = connectionString;
            }
        }

        public DbConnection (string connectionString, TimeSpan timeout)
            :this(connectionString)
        {
            Timeout = timeout;
        }

        public abstract void OpenDatabase ();

        public abstract void CloseDatabase ();
    }
}
