using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDEMO
{
    static class Calculator
    {
        //public int Add(int n1, int n2) { .....}
        //public int Add(int n1, int n2, int 3) { .....}
        //public int Add(int n1, int n2, int 3, int 4) { .....}
        // This is how you make over loads but this is bad practice
        // There's a better way to do this!

        /// /////////////////////// Example of params //////////////////////////////


        public static int Add(int[] numbers)
        {
            int sumOf = 0;
            foreach (int n in numbers)
            {
                sumOf += n;
            }

            return sumOf;
        }
        // The above will require an array of number to be instantiated in the main program
        // However adding the keyword "params" removes this requirement. This is simpler!!! 
        // Example below
        public static int Multiple(params int[] numbers)
        {
            int sumOf = 1;
            foreach (int n in numbers)
            {
                sumOf *= n;
            }

            return sumOf;
        }

    }
}
