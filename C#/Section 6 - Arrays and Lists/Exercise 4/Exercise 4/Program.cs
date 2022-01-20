using System;
using System.Collections.Generic;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to continuously enter a number or type "Quit" to exit.
            //The list of numbers may include duplicates.
            //Display the unique numbers that the user has entered.
            List<int> numbers = new List<int>();
            List<int> Unique = new List<int>();
            int loop = 1;           // looper int might not need this as break would work too
            string quit = "quit";   // just in case user does not use a captial q
            string Quit = "Quit";   // normal quit case
            do
            {
                
                Console.WriteLine("\nEnter a number or 'Quit' to exit");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) || string.Equals(quit, input) || string.Equals(Quit, input)) // Cleaner to group into one IF statement as OR
                {
                    loop = 0;
                    Console.WriteLine("Quit condition triggered"); //check correct behaviour when condition met
                    break;
                }
                //////////////// NOT BEST PRACTICE TO SEPARATE THE QUIT CONDITION AS IT DOES THE SAME THING ////////////////////
                //else if (string.Equals(quit, input))     
                //{
                //    loop = 0;
                //    Console.WriteLine("IF 2 triggered"); //check correct behaviour when condition met

                //    break;
                //}
                //else if (string.Equals(Quit, input))
                //{
                //    loop = 0;
                //    Console.WriteLine("IF 3 triggered"); //check correct behaviour when condition met

                //    break;
                //}
                //////////// CONSIDERED AS MESSY CODE ///////////////////////////////////////////////////////////////////////////
                else
                {
                    int number = Int32.Parse(input);  // Parse string input into an integer 
                    //numbers.Add(number);              // Add the number into the list
                    // Apply the display function
                    
                    
                        //Console.Write(n + ", ");    // Visual check for entered numbers
                        // Apply on unique number mask
                        if (numbers.Contains(number))
                        {
                            //Console.WriteLine("DOES CONTAIN NUMBER");
                            numbers.Add(number);
                            foreach (int n in Unique)
                            {
                            
                            Console.Write(n + ", ");

                            }
                        }
                        else if(!numbers.Contains(number))
                        {
                            //Console.WriteLine("DOES NOT CONTAIN NUMBER");
                            numbers.Add(number);
                            Unique.Add(number);
                            foreach (int n in Unique)
                            {
                            
                            Console.Write(n + ", ");

                            }

                        }
                        

                }
                                                  
                
            }
            while (loop > 0);
        }
    }
}
