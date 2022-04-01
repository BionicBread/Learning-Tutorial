using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            int ini = 0; 
            int max = 5;
            for (int i = ini; i <= max; i++)
            {
                stack.Push(i);
            }
            //stack.Clear(); //test the empty stack error
            for (int i = ini; i <=max; i++)
            {
                Console.WriteLine(stack.Pop());
            }

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            Console.WriteLine("Input 'Clear' to clear the stack or 'Quit' to exit");
            string input = Console.ReadLine();
            if (input == "Clear")
            {
                stack.Clear();
            }
            else if (input == "Quit")
            {
                Environment.Exit(0);
            }

            
        }
    }
}
