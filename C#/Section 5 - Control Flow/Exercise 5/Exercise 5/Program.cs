using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
            int total = 0;
            for (var i = 0; i <= 100; i++) 
                if (i%3 == 0)
                {
                    Console.WriteLine(i);
                    total++;
                }
            Console.WriteLine("total number divisible by 3 is " + total);
        }
    }
}
