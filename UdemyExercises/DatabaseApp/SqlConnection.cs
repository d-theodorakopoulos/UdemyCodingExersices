using System;

namespace DatabaseApp
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection (string connectionString,TimeSpan timeout)
            :base(connectionString,timeout)
        {
            
        }

        public override void CloseDatabase ()
        {
            Console.WriteLine("Close SQL Server Database");
        }

        public override void OpenDatabase ()
        {
            Console.WriteLine("Open SQL Server Database");
        }
    }
}
