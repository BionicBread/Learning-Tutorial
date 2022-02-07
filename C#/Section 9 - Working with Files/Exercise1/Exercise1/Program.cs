using System;
using System.IO;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program that reads a text file and displays the number of words.
            // use "C:\temp\tutorialTest"

            string contentsOfFile = File.ReadAllText(@"C:\temp\tutorialTest\someFile.txt");

            string[] numberOfWords = contentsOfFile.Split(' ');
            Console.WriteLine(numberOfWords.Length);



        }
    }
}
