using System;
//using System.Linq;
using System.Collections.Generic;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2- Write a program and ask the user to enter a few numbers separated by a hyphen.
            //If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates.
            //If so, display "Duplicate" on the console.

            List<int> listFormat = new List<int>();
            //bool isDuplicate;
            
            int ender = 0;
            do
            {
                Console.WriteLine("Input some numbers that is hypen separated - Duplicates will be detected");
                Console.WriteLine("To quit enter no values");
                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }

                string[] numbers = input.Split('-');
                //int[] intArray = new int[numbers.Length];
                int[] intArray = Array.ConvertAll(numbers, int.Parse);

                foreach (int n in intArray)
                    listFormat.Add(n);

                foreach (int k in listFormat)
                   
                    if (listFormat.IndexOf(k) == listFormat.LastIndexOf(k))
                    {
                        continue;
                    }
                    else if (listFormat.IndexOf(k) != listFormat.LastIndexOf(k))
                    {
                        Console.WriteLine("DUPLICATE");
                        ender++;
                        break;
                    }
      
                 
            }
            while (ender == 0);

        }
    }
}



