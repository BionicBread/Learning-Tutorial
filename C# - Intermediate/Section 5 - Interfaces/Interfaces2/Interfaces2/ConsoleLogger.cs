using System;

namespace Interfaces2
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red; // changes colour of console text colour
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green; // changes colour of console text colour
            Console.WriteLine(message);
        }
    }
}
