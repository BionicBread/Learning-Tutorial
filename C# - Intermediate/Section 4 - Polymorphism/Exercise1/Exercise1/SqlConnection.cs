using System;
namespace Exercise1
{
    public class SqlConnection : DbConnection
    {
        public override void OpenConnection()
        {

            System.Console.WriteLine("USING: " + ConnectionString);
            System.Console.WriteLine("Some API to OPEN connection to SQL");
            Console.WriteLine("Opening Connecting...");
            TimeSpan OpenStart = DateTime.Now.TimeOfDay;
            System.Threading.Thread.Sleep(2000); // simulate a connection time
            TimeSpan OpenEnd = DateTime.Now.TimeOfDay;
            if (OpenEnd.Subtract(OpenStart) >= TimeOut)
            {
                throw new Exception("Connnection Timed out");
            }
            else
                Console.WriteLine("Connected to SQL");

        }

        public override void CloseConnection()
        {
            System.Console.WriteLine("USING: " + ConnectionString);
            System.Console.WriteLine("Some API to Close connection to SQL");
            Console.WriteLine("Closing Connecting...");
            TimeSpan CloseStart = DateTime.Now.TimeOfDay;
            System.Threading.Thread.Sleep(11000);
            TimeSpan CloseEnd = DateTime.Now.TimeOfDay;
            if (CloseEnd.Subtract(CloseStart) >= TimeOut)
            {
                throw new Exception("Connnection Timed out");
            }
            else
                Console.WriteLine("Closed Connection to SQL");

        }


    }
}


