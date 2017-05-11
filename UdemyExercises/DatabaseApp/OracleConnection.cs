using System;

namespace DatabaseApp
{
    public class OracleConnection : DbConnection
    {

        public OracleConnection (string connectionString, TimeSpan timeout)
            :base(connectionString,timeout)
        {
            
        }

        public override void CloseDatabase ()
        {
            Console.WriteLine("Close Oracle Connection");
        }

        public override void OpenDatabase ()
        {
            Console.WriteLine("Open Oracle Connection");
        }
    }
}
