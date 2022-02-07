using System;
using System.IO;

namespace PathDEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path class, extract certain parts of the path

            string path = @"C:\temp\someFolder\someFile.sln";
            // say we want to extract only the extension information
            // low level solution:
            var dotIndex = path.IndexOf('.'); // find the index where a . is
            var extension = path.Substring(dotIndex); // take the text after the . by using the index

            // better solution
            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File name: " + Path.GetFileName(path));
            Console.WriteLine("File name with Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));

        }
    }
}
