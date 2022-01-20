using System;
using System.Collections.Generic;
namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter 5 numbers.
            //If a number has been previously entered, display an error message and ask the user to re-try.
            //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
            
            {
                List<int> numbers = new List<int>(); // init a list
                int loop = 0;
                Console.WriteLine("Enter a number 5 times. Each number must be unique");
                do
                {
                    Console.WriteLine("Number: " + (loop + 1));
                    string inputString = Console.ReadLine();


                    int input = Int32.Parse(inputString);


                    // apply unique number validation

                    if (numbers.Contains(input))
                    {
                        Console.WriteLine("Number already entered, try again");
                    }
                    else
                    {
                        Console.WriteLine("Number is unique");
                        numbers.Add(input);
                        loop++;
                    }

                }
                while (loop < 5);

                Console.WriteLine("These are your numbers: ");


                foreach (int i in numbers)
                {
                    Console.Write(i + ", ");
                }



           
        }
    }
}
