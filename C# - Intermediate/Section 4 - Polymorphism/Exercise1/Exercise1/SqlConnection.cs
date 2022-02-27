namespace Exercise1
{
    public abstract class SqlConnection : DbConnection
    {
        
        public void OpenConnection()
        {
            System.Console.WriteLine("USING: " + ConnectionString);
            System.Console.WriteLine("Some API to OPEN connection to SQL");
            //base.OpenConnection();
        }

        public void CloseConnection()
        {
            System.Console.WriteLine("Some API to CLOSE connection to SQL");
            //base.CloseConnection();
        }
    }
}
