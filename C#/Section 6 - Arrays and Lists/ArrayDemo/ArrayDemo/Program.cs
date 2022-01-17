using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 7, 9, 14, 6 }; // init an array

            // Size of array
            Console.WriteLine("Starter array:");
            foreach (int n in numbers)
            Console.WriteLine(n);
            Console.WriteLine("Length of start array is " + numbers.Length); // prints the size of the array

            //Indexof() method - search for object in array then returns the position of the object as an int
            int position = Array.IndexOf(numbers, 9);  // searchs numbers array for 9
            Console.WriteLine("Index of 9 is " + position);

            // Clear() method - clears elements to default value 0 between two indices
            Console.WriteLine("Clear method - clears a length of elements in an array to 0");
            Array.Clear(numbers, 0, 2); // clear starting at index 0 to 2 

            foreach (int n in numbers)
                Console.WriteLine(n); // prints the elements in array numbers after clearing the 0 and 1 index to zero

            // If a boolean array means clear will set to 0 to false
            // In a string array means clear will set to NULL

            // Copy() method - takes 3 parameters: 1st is source array 2nd is the destination array and 3rd is the length
            Console.WriteLine("Copy method - copy a length elements in an array to another array");
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach (int n in another)
                Console.WriteLine(n);

            // Sort() method - sorts the array from lowest to highest
            Console.WriteLine("Sort method - sorts an array from lowest to highest");
            Array.Sort(numbers);
            foreach (int n in numbers)
                Console.WriteLine(n);

            // Reverse() method
            Console.WriteLine("Reverse method - reverses the element index in an array");
            Array.Reverse(numbers);
            foreach (int n in numbers)
                Console.WriteLine(n);
            
            // NOTE
            // the length method is called from the array object
            // the other methods is called using the array class
            // the array class methods are static methods 
            // example
            // Array. will show the static methods in the Array class (such as: Clear () Copy() Sort() etc)
            // numbers. will show non static methods and are instance memebers 

            // methods can have different version known as overloads

            
        }
    }
}
