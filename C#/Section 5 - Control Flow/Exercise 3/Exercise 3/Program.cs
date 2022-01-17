using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
            Console.WriteLine("Enter a value for width");
            string width = Console.ReadLine();
            Console.WriteLine("Enter a value for length");
            string length = Console.ReadLine();

            int width2 = int.Parse(width);
            int length2 = int.Parse(length);

            if(width2 > length2 || length2 >width2)
            {
                Console.WriteLine("the shape is a rectangle");
            }
            else
            {
                Console.WriteLine("the shape is a square");
            }

        }
    }
}
