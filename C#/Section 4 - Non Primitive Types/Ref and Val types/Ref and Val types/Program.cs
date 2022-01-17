using System;

namespace Ref_and_Val_types
{
    public class Person
    {
        public int Age; 
    }

    class Program
    {
        static void Main(string[] args)
        {   //vaule type is stored in the stack and reference type is the heap
            //in the STACK variables copied are different memory location 
            //var a = 10; // a has the value 10
            //var b = a; // b copies the value in a
            //b++; // b is incremented by 1
            //Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            //// These are known as value types as only the value is copied over: a, b are independant from one another.
            //example with reference type: the array points to an object in memory location in the HEAP when changes are made i.e array2 the location it points to is the same memory location as array1
            //var array1 = new int[3] { 1, 2, 3 };
            //var array2 = array1;
            //array2[0] = 0;
            //Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

            //// These are known as reference types as the class array1 is referencing a memory location so a change to the array via array2 affects array1.

            var number = 1;
            Increment(number); //calls the Increment method then assigns number as the arguement
            Console.WriteLine(number);

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);

        }
        // Below are methods for the example.
        public static void Increment(int number)
        {
            number += 10; // adds 10 to the number passed to the method
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
