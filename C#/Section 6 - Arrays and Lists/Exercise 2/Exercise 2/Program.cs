using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter their name.
            //Use an array to reverse the name and then store the result in a new string.
            //Display the reversed name on the console.

            
            Console.WriteLine("Please enter a name");
            string nameInput = Console.ReadLine();
            char[] nameArray = new char[nameInput.Length];
            char[] reverseArray = new char[nameInput.Length];
            // Console.WriteLine(nameInput.Length); // checks the length of name entered

            //for (int i = 0; i < nameInput.Length; i++)
            int i = 0; // counter for array loop, purpose is same as i in a for loop
            int p = 0; // counter for reverse array loop, purpose is same as i in a for loop
                foreach (char c in nameInput)
                {
                    nameArray[i] = c;
                    //Console.WriteLine(nameArray[i]); //checks char in name array
                    i++; 
                }
            //Console.WriteLine(i);
            //////////////// WORKING SOLUTION////////////////
            //for (int n = nameInput.Length-1; n >=0; n--)
            //{
            //    Console.Write(nameArray[n]);
            //}
            /////////////// SKIPS array to string step /////

            // array to string step
            for (int n = nameInput.Length - 1; n >= 0; n--) // -1 so the index lines up with a 0 initiated array
            {
                reverseArray[p] = nameArray[n];
                p++;
            }

            string final = string.Join(" ", reverseArray);
            Console.WriteLine(final);

        }
    }
}
