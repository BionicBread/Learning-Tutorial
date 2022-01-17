using System;

namespace interationDEMO3
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (var i = 1; i <= 10; i++)
            //{
            //    if (i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            // for loop that displays even numbers. this loop can be written in all loop types

            //int i = 0; //i counter is declared outside of while loop
            //while (i <= 10)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //        i++;
            //    }
            //}

            //echo program - an entered string is repeated (echo)

            while (true) 
            {
                Console.Write("Type your name ");
                string input = Console.ReadLine();
                // if nothing is entered then it is an empty string
                // if (string.IsNullOrWhiteSpace(input)) // checks if string is empty. true will break aka end loop
                //    break;

                // Console.WriteLine("@Echo: " + input);

                // variation of same code but using NOT operator !

                if (!string.IsNullOrWhiteSpace(input)) // checks if string is empty. true will break aka end loop
                {
                    Console.WriteLine("@Echo: " + input);
                    continue; //continues to loop if above is true. False when string is null 
                }
                break;

                // this loop will only run once as it will reach the break command
                // to restore the loop behaviour we can add "continue" keyword
                // continue will restart the loop and not reach break
            }
        }
    }
}
