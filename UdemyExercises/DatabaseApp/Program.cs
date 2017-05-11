using System;

namespace DatabaseApp
{
    class Program
    {
        static void Main (string[] args)
        {
            OracleConnection oracle = new OracleConnection("dsada", new TimeSpan(3, 4, 2));
            SqlConnection sql = new SqlConnection("dwdwxw", new TimeSpan(5, 4, 3));

            DbCommand command = new DbCommand(oracle, "open");
            command.Execute();
            DbCommand command2 = new DbCommand(oracle, "close");
            command2.Execute();

            new DbCommand(sql, "open").Execute();
            new DbCommand(sql, "close").Execute();
            new DbCommand(sql, "opensd").Execute();

            Console.ReadKey();

        }
    }
}
