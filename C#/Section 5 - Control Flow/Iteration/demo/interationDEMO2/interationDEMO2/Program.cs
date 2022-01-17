using System;

namespace interationDEMO2
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic FOR loop for comparison

            //var name = "John Smith"; 
            // A string is a sequence of characters so it is innumerable aka a foreach loop would work on a string
            //iterate the string and display each character

            //for (var i = 0; i < name.Length; i++) // loop for i is less that the length of string "name" then increase i by 1
            //{
            //    Console.WriteLine(name[i]); //displays the element is position [] as i increase
            //}
            // same function but using foreach loop
            // advantage = no need for the counter condition
            // advantage = no need for comparing the length with i
            //foreach (var character in name) // works for array or list
            //{
            //    Console.WriteLine(character);
            //}

            var numbers = new int[] { 1, 2, 3, 4 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }

    }
}
