using System;
namespace Exercise1
{
    public abstract class OracleConnection : DbConnection 
    {
        public override void OpenConnection()
        {
            Console.WriteLine("Some API to OPEN connection to Oracle");
            //base.OpenConnection();
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Some API to CLOSE connection to Oracle");
            //base.CloseConnection();
        }
    }
}
