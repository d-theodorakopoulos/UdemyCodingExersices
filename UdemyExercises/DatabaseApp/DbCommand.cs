using System;

namespace DatabaseApp
{
    public class DbCommand
    {
        private DbConnection _connetion;
        private string _command;

        public DbCommand (DbConnection connection, string command)
        {
            if (connection == null || string.IsNullOrWhiteSpace(command))
                throw new Exception("Wrong Argument!");

            _connetion = connection;
            _command = command;
        }

        public void Execute()
        {
            Console.WriteLine("Run Command");
            switch (_command)
            {
                case "open":
                    _connetion.OpenDatabase();
                    break;
                case "close":
                    _connetion.CloseDatabase();
                    break;
                default:
                    Console.WriteLine("Wrong command!");
                    break;
            }
        }
    }
}
