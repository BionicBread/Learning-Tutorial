using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a series of numbers separated by comma.
            //Find the maximum of the numbers and display it on the console.
            //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.WriteLine("Enter a series of numbers separated by comma");
            
            string userInput = Console.ReadLine();
            
            
            string[] input = userInput.Split(','); // Splits the string separated by comma

            int[] array = Array.ConvertAll(input, int.Parse); // Parse string array into int array

            //foreach (var element in input)  //checks element correctly contains the numbers separated by comma
            //{
            //    Console.WriteLine(element);
            //}

            //foreach (int element in array)  //checks the int array elements have been converted from string array
            //{
            //    Console.WriteLine(element);
            //}
            int newMax = 0;
            int newMin = 0;
            foreach (int element in array)
            {
                int max = array[1];
                int min = array[1];
                
                if (element > max)
                {
                    newMax = element;
                }
                else if (element < min)
                {
                    newMin = element;
                }

            }
            Console.WriteLine("The maximum value is " + newMax);
            Console.WriteLine("BONUS: The minimum value is " + newMin);




        }
    }
}
