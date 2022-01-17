using System;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // random class generates random numbers
            var random = new Random(); //create an instance of the random class
                                       // the random class contains useful methods
                                       // random.Next  - random integar
                                       //random.NextBytes - fills a byte array with random numbers
                                       //random.NextDouble - returns a random double from 0 to 1

            // next method
            //for (var i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(random.Next()); // using the 1st overload (method option) loop will iterate 10 times with random numbers displayed
            //}

            //for (var i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(random.Next(1, 10)); // using 2nd overload, a min and max boundary can be created i.e random numbers between 1 to 10
            //}

            //Console.WriteLine((int)'a'); // lower case a is cast to int: ASCII code for the letter a is printed
            // using random to generate numbers from 97 to 122 (ASCII range for a to z) random password can be generated
            //for (var i = 0; i < 10; i++)
            //{
            //    Console.Write((char)random.Next(97, 122)); // min and max boundary for ASCII a to z .NEXT method returns a number so cast to character is required
            //}
            // Another way to write this code in a more user friendly way
            //for (var i = 0; i < 10; i++)
            //{
            //    Console.Write((char)'a' + random.Next(0, 26)); // here the character a is adding a random number from 0 to 26 (letters in alphabet). The ACSCII number is used for the addition.
            // same outcome as previous

            // ideally, password is saved as a string. But strings are immutable aka it cannot be changed once made
            // we can create strings from an array of letters

            //    char[] buffer = new char[10]; // declare character array of size 10
            //for (var i = 0; i < 10; i++)
            //    buffer[i] = (char)('a' + random.Next(0, 26)); 
            // generates a random letter in the buffer array 10 times
            // a + random number then cast into char type
            // last step is to generate a string from the array
            // string password = ""; // one way to create a string
            //string password = new string(buffer);
            //Console.WriteLine(password);

            // IMPROVEMENT
            // contant can be created for the password length so it does not require manual changing 
            // declare constant then use in loop if length of password needs to be changed we just change the constant
            const int passwordLength = 10;

            char[] buffer = new char[passwordLength]; 
            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

          
            string password = new string(buffer);
            Console.WriteLine(password);
        }
        }   
}

