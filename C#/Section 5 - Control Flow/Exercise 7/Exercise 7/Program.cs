using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a number.
            //Compute the factorial of the number and print it on the console.
            //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            
            {
                Console.WriteLine("Enter a number to become a factorial");
                string input1 = Console.ReadLine(); // user input a number
                int input2 = int.Parse(input1); // Parse input string into double
                int product = 1;               
                int[] array = new int[input2]; // init an array with size input2 

                for (int i = 0; i <= input2-1; i++) // input2-1 so there is no extra element containing 0
                {
                    array[i] = i+1; // ensures that element zero is stored with value 1

                    //Console.WriteLine(array[i]);  //check
                }

                //a = (array[5]) * (array[4]) * (array[3]) * (array[2]) * (array[1]); this is what i want to achieve

                foreach (int number in array) // array contain 1,2,3,4,5 
                {
                       product *= number;  // *= multiply the right value into the left value 
                                           // product starts at 1 so 1 * 1 for first loop (otherwise it would be 0 * 1 which will always be zero as it loops)
                                           // then 1 * 2 
                                           // then 2 * 3
                                           // ....until it reaches 5 
                                           // product = 1*2*3*4*5

                //    Console.WriteLine(number);   
                }
                Console.WriteLine(input2 + "! is " + product);

                
            }
        }
    }
}
