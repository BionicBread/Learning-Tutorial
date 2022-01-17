using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string firstName = "Chris"; // 'type' 'name' = "text"; 
            string lastName = "Yu"; 
            //strings can be apended to on other string: concatinate 

            string name = firstName + " " + lastName; // concatinate with the + symbol. The space between the quotes is the space between the first and last name.

            Console.WriteLine(name);

            //Altnative method is to use string .format keyword (static method)

            string names = string.Format("{0} {1}", firstName, lastName); // the {} are the parameters for the method .format. These parameters are replaced by firstName and lastName

            Console.WriteLine(names);

            //you can also concatinate with the .join method

            var numbers = new int[3] { 1, 2, 3 }; // Create an array with 3 numbers
            string list = string.Join(",", numbers); // the "," is a separator now the elements in the int array is joined together in a string.

            Console.WriteLine(numbers); // This will not print the elements in the array
            Console.WriteLine(list);    // This will print the elements in the the array

            // Extract the first character from a string

            string otherName = "Nicola";

            char firstChar = otherName[0]; // first element in the string

            Console.WriteLine(firstChar);

            // String are immutable cannot be changed. Cannot change an element in the string.

            // String commands:
            // \n = new line
            //\t = tab
            //\\ = backslash
            //\' = single quote
            //\'' = double quote

            string example = "hello \nthis is on a new line \t this is tabbed away \\ <<backslash \'cool\'";
            Console.WriteLine(example);

            // Verbatim string
            // string path = "C:\\Users\\bioha\\Documents\\Coding\\C#"
            // this is messy with lots of backslash 
            string path = @"C:\Users\bioha\Documents\Coding\C#";
            Console.WriteLine(path);



        }

    }
}
