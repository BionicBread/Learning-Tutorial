using System;
using System.Collections.Generic;
using System.Text;
namespace Exercise1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //1- Write a program and ask the user to enter a few numbers separated by a hyphen.
            //Work out if the numbers are consecutive.
            //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
            Console.WriteLine("Enter a series of numbers separated by '-' either consecutive or non consecutive");
            string input = Console.ReadLine();
            SequenceLogic.ConsecutiveCheck(input);
            

        }        
                
    }
}
