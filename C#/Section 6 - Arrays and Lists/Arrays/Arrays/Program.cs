using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1d = new int[3]; // 1d array with 3 elements

            // Multi dimensional array
            // Rectangular array i.e 3 x 5 
            // Jagged array i.e array of array of different size

            int[,] matrix = new int[3, 5]  // Object initialisation of a 3 x 5 array 
            {
                {1,2,3,4,5},
                {6,7,8,9,10},
                {11,12,13,14,15}
            };

            int element = matrix[0, 0]; // access an element 0, 0
            Console.WriteLine(element); // check the value in element

            //Jagged - Array of array of different sizes
            // | x | x | x | x
            // | x | x | x | x | x
            // | x | x | x 

            // Declare the number of rows 

            int[][] jagged = new int[3][]; //[][] double brackets

            // Declare the size of the number of elements in each row

            jagged[0] = new int[4];
            jagged[1] = new int[5];
            jagged[2] = new int[3];

            jagged[0][0] = 1; // To access an element
                   
        }
    }
}
