using System;

namespace ClassDEMO
{
    class Program
    {
        static void Main(string[] args)
        {

            ///// params example here //////////////////

            var results = Calculator.Add(new int[] { 1, 2, 3, 4, 5 }); // no params used in method so array needs to be instantiated
            Console.WriteLine(results);   

            var multiply = Calculator.Multiple(1, 2, 3, 4, 5); // params used in the multiply method so input parameters can just be numbers
            Console.WriteLine(multiply);

            /// ref example here /////////////////////
            int a = 1;
            int b = 1;
            RefClass.MyMethod(a);
            Console.WriteLine("Without ref in the method: " + a); // The the method without ref ignores the declaration outside of the method and the result is 1

            RefClass.MyRefMethod(ref b); // Using ref will not reference a variable outside of the method and the result is 3. 
            Console.WriteLine("With ref in the method: " + b); // AVOID LIKE THE PLAGUE

            //// out example here /////
            int c;
            OutClass.OutMethod(out c); // Using the "out" keyword is basically return. ALSO AVOID LIKE THE PLAGUE
            Console.WriteLine("Out keyword in method: " + c);  // should be 1 
        }
    }
}
