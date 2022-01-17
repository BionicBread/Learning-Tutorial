using System;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Chris";
            //int number;
            //all the data types are mapped to the .net framework 
            //String lastName = "Chris1"; //same as above but String is a class in the System namespace must have "using System";  
            

            var firstName = "Chris";
            var lastName = "Yu";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("my name is {0} {1}", firstName, lastName); //another way to concatonate by using .format in the string class
            Console.WriteLine(myFullName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join("| ", names); // Each element is separated by |
            Console.WriteLine(formattedNames);

            var text = "Hi John\nLook into the following path\nC:\\folder\\folder1\nC:\\file\\file2";
            Console.WriteLine(text);
            // Above is messy, verbatim string used to minimize the path string

            var textVer = @"
Using verbatim
Hi John
Look into the following path
C:\folder\folder1\
C:\file\file2";
            Console.WriteLine(textVer);

        }
    }
}
