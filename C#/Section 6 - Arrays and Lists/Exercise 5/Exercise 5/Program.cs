using System;
using System.Collections.Generic;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
            //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
            //otherwise, display the 3 smallest numbers in the list.

            List<int> ListNumbers = new List<int>();
            List<int> threeLowest = new List<int>();
            int loop = 0;
            do
            {
                Console.WriteLine("Input at least 5 comma separated numbers");
                string userInput = Console.ReadLine();

                /////////////////// ARRAY SOLUTION  ///////////////////////////////////////////////////
                //string[] input = userInput.Split(','); // put every number separated by a comma into an string array

                //int[] array = Array.ConvertAll(input, int.Parse); // parse the array of string numbers into a int array

                ////foreach (var element in input)  //checks element correctly contains the numbers separated by comma
                ////{
                ////    Console.Write(element + ", ");
                ////}
                //if (array.Length < 4)
                //{
                //    Console.WriteLine("Invalid list - Retry");

                //}
                //else if (array.Length >= 4)
                //{
                //    //Console.WriteLine("TRIGGERED cn2"); // check trigger condition is met
                //    Array.Sort(array);
                //    for (int i = 0; i <= 2; i++)
                //    {
                //        Console.WriteLine(array[i]);

                //    }

                //    loop = 3;
                //}
                ////////////////// ARRAY SOLUTION /////////////////////////////////////////////////////
                ///

                //////////////// LIST SOLUTION ////////////////////////////////////////////////////////

                string[] formatInput = userInput.Split(',');                // Separate numbers inbetween comma
                int[] array = Array.ConvertAll(formatInput, int.Parse);     // Covert string array into int array
                //int i = 0; // counter for check loop
                foreach(int n in array)     // loop through each element in array
                {
                    ListNumbers.Add(n);     // add each element in array into the list
                    //Console.WriteLine(ListNumbers[i]); // check
                    //i++;                               // increment the check counter
                }

                if (ListNumbers.Count < 4)
                {
                    Console.WriteLine("Invalid list - Retry");
                }

                else if (ListNumbers.Count >= 4)
                {
                    ListNumbers.Sort();
                    for (int n = 0; n <= 2; n++)
                    {
                        Console.Write(ListNumbers[n] + ", ");
                        
                    }
                    loop = 3;
                }

            }
            while (loop <= 2);
        }
    }
}
