using System;

namespace WorkingwithTimeandDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime();
            var now = DateTime.Now;  // DateTime contains methods for getting the current date and time
            var today = DateTime.Today; // gets current date

            Console.WriteLine("Hour " + now.Hour); // print specific time from the variable
            Console.WriteLine("Mins " + now.Minute); // i.e minutes

            var tomorrow = now.AddDays(1); // add days to the current time
            var yesterday = now.AddDays(1); // date time objects in C# are immutable
                                            // use the .Add to change
                                            // negative to subtract days

            // convert date time to string

            Console.WriteLine(now.ToLongDateString()); //converts the date time to a string in a certain format
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            Console.WriteLine(now.ToString()); // date and time together
            Console.WriteLine(now.ToString("yyyyy-MM-dd")); // with formatting specified 
            


        }
    }
}
