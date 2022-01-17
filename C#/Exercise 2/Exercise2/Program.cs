using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program which takes two numbers from the console and displays the maximum of the two.

            Console.WriteLine("Please input a number for a");
            string a = Console.ReadLine();
            Console.WriteLine("a = " + a); //check
            Console.WriteLine("Please input a number for b");
            string b = Console.ReadLine();
            Console.WriteLine("b = " + b); //check

            int a2 = int.Parse(a);
            int b2 = int.Parse(b);

            int maxValue = Math.Max(a2, b2);
            Console.WriteLine("max value is " + maxValue); //this works!

            // using the if statement however cannot include the case a2 = b2
            //if (a2 > b2)
            //{
            //    Console.WriteLine("a is larger than b");
            //}
            //else
            //{
            //    Console.WriteLine("b is larger than a");
            //}
            


            // using the try parse method - DOESNT WORK!
            //try
            //{
            //    int convertA = Int32.Parse(a);
            //    int convertB = Int32.Parse(b);

            //    if (convertA > convertB)
            //    {
            //        Console.WriteLine("a is the larger value");
            //    }
            //    else
            //    {
            //        Console.WriteLine("b is the larger value");
            //    }

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Cannot not parse string to int");
            //}


        }
    }
}
