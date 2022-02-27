using System;

namespace Exercise1
{
    public abstract class DbConnection
    {
        private string _connectionString; // private string that is changed in the property ConnectionString
        private TimeSpan _timeOut;
       

       
        public TimeSpan TimeOut 
        {
            get { return _timeOut; } 
        }
        public string ConnectionString 
        {
            get 
            { 
                return _connectionString; 
            }
            set  // logic stops null or empty string being set to the _connectionString
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Connection string is Null or Empty");
                }
                else if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("Connection string is Null or WhiteSpace");
                } 
                else
                    _connectionString = value;
            }
              
        }
        public DbConnection()
        {
            ConnectionString = "someConnectionString";  // start with hard coded connectionString 
            _timeOut = TimeSpan.FromSeconds(10);   // assign 10 sec value to 
        }
        //public DbConnection(string inputString) // constructor that requires a connection string when instansiating
        //{
        //    ConnectionString = inputString; // uses the setter logic in the ConnectionString property
        //}

        public abstract void OpenConnection();




        public abstract void CloseConnection();
        

        
    }
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
