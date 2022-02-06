using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4- Write a program and ask the user to enter a few words separated by a space.
            //Use the words to create a variable name with PascalCase.
            //For example, if the user types: "number of students", display "NumberOfStudents".
            //Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".  
            
            Console.WriteLine("Enter a variable name to be converted to PascalCase");
            string wordsToBeChanged = Console.ReadLine();


            //foreach (byte b in ASCIIMod.ASCIIChange(wordsToBeChanged)) // checks ASCIIChange method works
            //{
            //    Console.WriteLine(b);
            //}
            //foreach (int n in ASCIIMod.FindLength(wordsToBeChanged)) // check FindLength method works
            //{
            //    Console.WriteLine(n);
            //}
            string[] stringArray = wordsToBeChanged.Split(' ');
            StringBuilder builder = new StringBuilder();
            foreach (string value in stringArray)
            {
                builder.Append(value);
                
            }
            string result = builder.ToString();
            byte[] asciiArray = ASCIIMod.ChangeToASCII(result, ASCIIMod.FindLength(wordsToBeChanged));

            Console.WriteLine(ASCIIMod.ChangeToString(asciiArray));
            //string finalString = ASCIIMod.ChangeToString(asciiArray);
            //string[] finalStringSplit = finalString.Split(' ');

            //foreach (string s in finalStringSplit)
            //{
            //    Console.Write(s);
            //}



        }
    }
}
