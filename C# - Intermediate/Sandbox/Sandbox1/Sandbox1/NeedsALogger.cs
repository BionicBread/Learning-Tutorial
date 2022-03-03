namespace Sandbox1
{
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
}
