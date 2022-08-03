using System;
namespace Generics
{

        public class Utilities<T> where T : IComparable
        {
            // add constraints to the generic
            // method to return the larger of two int

            public int Max(int a, int b) // normal method using defined data types
            {
                return a > b ? a : b; // if a is bigger than b return a if not return b
            }

            public T Max(T a, T b) //where T : IComparable // generic method, accessor then return type then name of method then template parameter then a is type T and b is type T
            {
                // return a > b ? a : b;  // this line does not work because we dont know the type of T for a & b yet
                // assume a & b implement the IComparable interface
                // use the where keyword in the method line. T is IComparable
                return a.CompareTo(b) > 0 ? a : b; // <<< a compare to b is less than 0 if true return a otherwise return b

                // Generic method in a non generic class is fine. Define the generic T in the method name otherwise
                // the where keyword can be moved to the class line 

            }
            // There are different types of constraints 
            // where T : IComparable << constrained to interface
            // where T : Product << constrained to a class
            // where T : struct << constrained to a value type
            // where T : class << constrained to a reference type
            // where T : new() << object with a default constructor
        }
    
}
