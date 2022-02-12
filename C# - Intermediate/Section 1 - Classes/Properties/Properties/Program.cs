using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Example person = new Example(new DateTime(1999, 2, 11));
           
            Console.WriteLine(person.Age);

        }
    }
}
