using System;

namespace Iteration_DEMO
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Display a list of even numbers from 1 to 10 then check it is even by dividing by 2 
            for (var i = 1; i <= 10; i++)
            {
                if (i%2 == 0) //validates condition that i is even
                    {
                        Console.WriteLine(i); // writes the number in i when even condition is met
                    }
            }

            // Reverse the process
            for (var i = 10; i >= 1; i--)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
