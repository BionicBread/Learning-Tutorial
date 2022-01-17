using System;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 10; i++) //for loop, i = 10 is the counter aka initialization clause. i < 10 is the condition clause, loop will continue for as long as the condition is valid. i++ iteration clause usually increase or decrease  
            {
                Console.WriteLine(i);
            }
            int[] array = new int[3] { 1, 2, 3 }; //"for each" iterates elements in an numerible array/list 
            foreach (var number in array)
            {
                Console.WriteLine(number);
            }
            int b = 0;
            while (b < 10) //while b is less than 10 then increase by 1
            {
                b++;
            }
            int c = 0;
            do // do-while loop iterates atleast once. The condition is evaluated at the end of the loop.
            {
                c++;
            } while (c < 10);
            // Break and continue statement 
            // break jumps out of loop aka stop
            // continue jumps to next loop
            
        }

    }
}
