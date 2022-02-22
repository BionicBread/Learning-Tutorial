using System;
using System.Collections.Generic;
using System.Collections;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object type is the parent of all native classes in .NET
            // BOXING - the process of converting a value type instance to an object reference
            // i.e
            int number = 10;          // number is an integer with value 10
            object obj = number;      // cast the value type into object type obj 
            // or
            object obj1 = 10;           // declare an obj

            // WHAT DOES THIS MEAN? ///////////////
            // Value types are stored in the stack part of the memory (all primitive types: byte, int, float, char, bool and struct type)
            // Reference types are stored in the heap part of the memory (any classes: Object, Array, String, etc)
            // By casting a value type into an object means it will be BOXED by CLR and stored in the HEAP instead of the STACK
            // 
            // UNBOXING - opposite of boxing
            // There is a performance penalty because of the extra operation 
            object obj2 = 10;
            //or
            int number2 = (int)obj;

            //// EXAMPLE /////////////////////////////
            ///
            var list = new ArrayList();
            list.Add(1);
            list.Add("NAME");
            list.Add(DateTime.Today);
            
            
        }
    }
}
