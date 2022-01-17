using System;
using ClassExample2.Math;

namespace ClassExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person(); // class Person does not use the static modifier so object john is created to access members in the Person class
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = Calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
