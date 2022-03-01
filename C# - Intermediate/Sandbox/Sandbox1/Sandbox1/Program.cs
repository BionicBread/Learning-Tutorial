namespace Sandbox1
{
    public class DataLogger
    {
        public void startLogger(string message)
        {
            System.Console.WriteLine(message);
        }
    }

    class NeedsALogger
    {
        private readonly DataLogger _logger;

        public NeedsALogger(DataLogger logger) // this is composition 
        {
            this._logger = logger; // field points to the object
        }

        public void LogMethod()
        {
            _logger.startLogger("STARTED!"); // use the object via field variable to access the object class methods
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var needsALogger = new NeedsALogger(new DataLogger()); //init with object instansiation as per constructor

            needsALogger.LogMethod();


        }
    }
}
