using System;
using System.IO;

namespace Exericse_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2- Write a program that reads a text file and displays the longest word in the file.
            // use C:\temp\tutorialTest\someFile.txt

            string textFile = File.ReadAllText(@"C:\temp\tutorialTest\someFile.txt");

            string[] words = textFile.Split(' ');
            int wordSize = 0;
            string largestWord = null;
            foreach (string s in words)
            {
               
                if (s.Length > wordSize)
                {
                    largestWord = s;
                    wordSize = s.Length;
                }
                else if (s.Length < wordSize)
                {
                    continue;
                }
            }

            Console.WriteLine(largestWord);
        }
    }
}
