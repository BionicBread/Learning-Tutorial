using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(DateTime.Now);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

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
