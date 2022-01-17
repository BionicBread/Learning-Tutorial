using System;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            // An Array is a data structure to store a collection of variables of the same type
            // ex: 
            //int[] numbers = new int[3]; // Array is an onject so it needs to be allocate memory with "new". The value in [] denotes the size of the array.
            // Array are zero indexed aka first element is 0
            // int[] numbers = new int[3]{ 1, 2, 3} use {} to enter values in array
            //int[] number = new  int [3]
            //"array" "name" = new "type[size]" 
            // int[] can be replaced with var

            var number = new int[3];
            number[0] = 1;

            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);

            //Default values in an int array is 0

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            //Default values in an bool array is false

            var names = new string[3] { "Jack", "John", "Mary" }; // No default value for strings, if an element is missing it will flag an error during run

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
        }
    }
}
