using System;

namespace timeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating time span objects
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0); // might be unclear
            var timeSpan2 = TimeSpan.FromHours(1); // same as the line above but we can tell it's clearly the hours that's changed


            ////////////// TimeSpan can be made like this ////////////////////////////////////////
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration" + duration);

            // properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes); // returns only the minute component in the timespan
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes); // Takes the total minutes in the timespan including hours
                                                                          // var timeSpan is 1hr 2mins and 3sec 
                                                                          // 62min and 3 sec is displayed
            // add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8))); // Add 8 mins to var timeSpan so displays 1hr 10Mins
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(8))); // Subtract

            // conversion to a strings

            Console.WriteLine("ToString" + timeSpan.ToString());

            // parse a string to a timespan
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));




        }
    }
}
