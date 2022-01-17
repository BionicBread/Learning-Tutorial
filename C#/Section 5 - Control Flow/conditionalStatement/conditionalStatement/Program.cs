using System;

namespace conditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //if statement best practice to enclose statement in curly brackets
            //int hour = 10;

            //if (hour > 0 && hour < 12)
            //{
            //    Console.WriteLine("it's morning.");
            //}

            //else if (hour >= 12 && hour < 18)
            //{
            //    Console.WriteLine("it's afternoon");
            //}

            //else
            //{
            //    Console.WriteLine("it's evening");
            //}

            ////conditional operator
            //bool isGoldCustomer = true;
            ////float price;
            ////if (isGoldCustomer)
            ////{
            ////    price = 19.95f;
            ////}
            ////else
            ////{
            ////    price = 29.95f;
            ////}

            ////the above can be rewritten as a conditional 

            //float price = (isGoldCustomer) ? 19.95f : 29.95f; //same as above: if condition is true then price = 19.95 otherwise 29.95
            //Console.WriteLine(price);

            //Enum Season created in another file
            //var season = Season.Autumn;
            //switch (season)
            //{
            //    case Season.Autumn:
            //        Console.WriteLine("It's Autumn");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("It's Summer");
            //        break;
            //    default:
            //        Console.WriteLine("No season then");
            //        break;
            //}
            // Grouping two cases with the same output
            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We have a promotion"); //if season is autumn or summer
                    break;
                default:
                    Console.WriteLine("No season then");
                    break;
            }
        }
    }
}
