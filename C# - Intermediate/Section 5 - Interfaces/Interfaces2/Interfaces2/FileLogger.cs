using System.IO;
namespace Interfaces2
{
    public class FileLogger : ILogger // lets say we want to change the way logging is done we dont need to 
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            this._path = path;
        }
        void ILogger.LogError(string message)
        {
            //StreamWriter sWrite = new StreamWriter(_path, true); // 2 arugments
            //sWrite.WriteLine(message); // certain object is not handled by the CLR and needs to be manually disposed of
            //instead the "using" keyword is used that will dispose the object
            //using (StreamWriter sWrite = new StreamWriter(_path, true))
            //{
            //    sWrite.WriteLine("ERROR " + message); //
            //    //sWrite.Dispose(); // dispose method is used to release memory that is not done by the CLR. The "using" keyword does this for us
            //}
            logging(message, "ERROR");

        }

        void ILogger.LogInfo(string message)
        {
            //using (StreamWriter sWrite = new StreamWriter(_path, true))
            //{
            //    sWrite.WriteLine("INFO " + message); // Notice how this is repeated code. REMEMBER D.R.Y - Don't Repeat Yourself
            //}
            logging(message, "INFO");
        }

        private void logging(string message, string messageType) // to avoid code duplication a private method can be used
        {
            using (StreamWriter sWrite = new StreamWriter(_path, true)) 
            {
                sWrite.WriteLine(messageType + ": " + message);  // can also be done with an Enum type, try this as an exercise
            }
        }
    }
}
