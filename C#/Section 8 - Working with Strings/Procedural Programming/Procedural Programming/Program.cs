using System;

namespace Procedural_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classes based on functions and methods 
            // Different from object orientated 
            // Procedural aka code excuted line by line

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine(ReverseName(name));

            //char[] array = new char[name.Length];
            //for (int i = name.Length; i > 0; i--)
            //{
            //    array[name.Length - i] = name[i - 1];
            //}
            //string reversed = new string(array);
            //Console.WriteLine("Reversed name: " + reversed);

            // the above logic can be placed into a separate method
        }
        public static string ReverseName(string name)
        {
            char[] array = new char[name.Length];
            for (int i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }
            return new string(array);
            
        }

    }
}
