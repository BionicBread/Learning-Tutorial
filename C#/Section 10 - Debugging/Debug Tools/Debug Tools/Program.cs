using System;
using System.Collections.Generic;

namespace Debug_Tools
{
    class Program
    {
        // F9 - Breakpoint
        // F5 - Run in debug
        // Ctrl F5 - Run without debug (Release)

        // F10 - Step Over
        // F11 - Step Into
        // Shift F11 - Step Out
        // Shift F5 - Exit debugger
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2};
            var smallest = GetSmallests(numbers, 1);

            foreach (int number in smallest)
            {
                Console.WriteLine(number);
            }

            
        }
        public static List<int> GetSmallests(List<int> list, int count)
        {
            if (list == null)
                throw new ArgumentNullException("list");

            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("count", "Count should be between 1 and the number of elements in the list");

            var buffer = new List<int>(list);
            List<int> smallest = new List<int>();

            while (smallest.Count < count)
            {
                int min = GetSmallest(list);
                smallest.Add(min);
                buffer.Remove(min);

            }
            return smallest;
        }
        public static int GetSmallest(List<int> list)
        {
            // Assume first number is the smallest
            var min = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                }
                
            }
            return min;
        }
    }
}
