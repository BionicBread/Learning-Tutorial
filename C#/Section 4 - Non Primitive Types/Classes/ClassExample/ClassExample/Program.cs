using System;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
       
        }
    }
    public class Person // "public" keyword is an access modifier
    {
        public string Name; // variable can be declared within a class
        public void Introduction() // functions can be declared within a class. void means no return and the empty () means no input parameters
        {
            Console.WriteLine("Hi my name is " + Name); //concatinate a text with a string variable
        }
    }
    public class Calculator
    {
        public int Add(int a, int b) //function "Add" with require variable a and b parameter and then return the operation of adding the two variables
        {
            return a + b;
        }
        // creating an object
        Person person = new Person(); // Because objects are not like primitive types the "new" operator is used to allocate memory. However in a Common Language Runtime (CLR) will take care of that unlike other languages like C / C++

        // alternative way to create an object using the var keyword
        // var person = new Person(); 
        // person.Name = "Chris";  //with person declared as an object it can be used to access the members in that object
        // person.Introduce(); // call the introduce method to use the name variable.

        // Static modifier

        // using the previous calculator method
        // public static int Add(int a, int b)
        //{
        //    return a + b;
        //}
        // Static modifier means I can access the function "add" using the "calculator" class
        // ie
        // int result = Calculator.Add(1,2);
        // No need to create an object to access static members.
}
}
