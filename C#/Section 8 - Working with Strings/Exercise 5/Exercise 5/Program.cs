using System;
using System.Text;
using System.Collections.Generic;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5- Write a program and ask the user to enter an English word.
            //Count the number of vowels (a, e, o, u, i) in the word.
            //So, if the user enters "inadequate", the program should display 6 on the console.

            Console.WriteLine("Enter an English word, the number of vowels will be counted");
            string input = Console.ReadLine();
          
            Console.WriteLine("Number of vowels: " + VowelCounter.CounterOfVowels(input));







        }
    }
}
