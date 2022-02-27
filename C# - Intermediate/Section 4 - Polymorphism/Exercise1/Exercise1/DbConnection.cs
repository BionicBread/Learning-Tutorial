using System;

namespace Exercise1
{
    public class DbConnection
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

       public virtual void OpenConnection()
        {

        }

        public virtual void CloseConnection()
        {

        }
    }
}
