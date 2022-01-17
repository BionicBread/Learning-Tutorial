using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
            int i = 0;
            double b = 0; // placeholder for sum
            while (true)
            {
                Console.WriteLine("Enter number or type ok to exit");
                string input = Console.ReadLine();

                if (string.Equals(input, "ok")) // exit condition
                {
                    break;
                }
                
                i++; // interation counter
                
                double a = int.Parse(input); // converts input to double 
                Console.WriteLine("input number " + (a + b));
                b = (a+b);
                Console.WriteLine("loop counter = "+i);
                //Console.WriteLine("number to add "+b); check
            }
        }
    }
}
