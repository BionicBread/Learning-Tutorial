using System;
namespace Exercise1
{
    public class OracleConnection : DbConnection 
    {
        public override void OpenConnection()
        {
            System.Console.WriteLine("USING: " + ConnectionString);
            Console.WriteLine("Some API to OPEN connection to Oracle");
            //base.OpenConnection();
        }

        public override void CloseConnection()
        {
            System.Console.WriteLine("USING: " + ConnectionString);
            Console.WriteLine("Some API to CLOSE connection to Oracle");
            //base.CloseConnection();
        }
    }
}
