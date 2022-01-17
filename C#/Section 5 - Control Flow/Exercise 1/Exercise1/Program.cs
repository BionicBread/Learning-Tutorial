using System;

namespace Exercise1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Write a program and ask the user to enter a number.
            //The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
            //(This logic is used a lot in applications where values entered into input boxes need to be validated.)
            Console.WriteLine("Please enter a number between 1 to 10");
            string inputNumber = Console.ReadLine();
            // Console.WriteLine("your number is " + inputNumber); //check

            try
            {
                int convertNumber = Int32.Parse(inputNumber);
                // Console.WriteLine("Parse = " + convertNumber); //check
                if(convertNumber <= 10 && convertNumber > 0)
                {
                    Console.WriteLine("your number is valid");
                }
                else
                {
                    Console.WriteLine("your number is invalid");
                }
                   
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{inputNumber}'");
            }

            
               
        
        }
    }
}
