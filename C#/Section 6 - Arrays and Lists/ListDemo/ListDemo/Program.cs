using System;
using System.Collections.Generic; //imports the namespace for List

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4 }; //init an int List. The angled brackets indicates a generic type
            numbers.Add(1);  // add element to the end of the list with the object 1   
            // Unlike an Array there is no add method. Arrays once created the size cannot be change

            numbers.AddRange(new int[3] { 5, 6, 7 });   // the .AddRange wants an IEnumerable<int> 
                                                        // this is an interface - the rule of thumb when IEnumerable is an input parameter is to use an Array or List
                                                        // interface is implemented by different classes
                                                        // .AddRange will add the int array objects onto the list
            
            foreach(var number in numbers)
                Console.WriteLine(number);              // the above is shown as a list

            // indexOf method

            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));      // 1st overload: searches the list for an object otherwise returns -1
                                                                         // in the example, it searchs for the 1st occurance of 1 then returns the index of the object
                                                                         // 1 is in the 1st element so it will return 0
                                                                         // 2nd overload: searches from a defined index .IndexOf (T, int32)
                                                                         // 3rd overload: searches in the boundary of defined index .IndexOf (T, int32, int32)

            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1)); // LastIndexOf: starts the search at the end of the list
                                                                             // finds the 1st occurence of 1 then returns the index
                                                                             // the numbers list has two objects of 1 
                                                                             // searching from the end of the list the return should be 4

            // Count method

            Console.WriteLine("Count: " + numbers.Count);       // Counts the number of objects in the list

            // Remove method

            numbers.Remove(1); // removes one instance of the defined object
            foreach(var number in numbers)
            Console.WriteLine(number); // ONLY removes one instance

            // to remove all 1 in the list

            //foreach (var number in numbers)
            //{
            //    if (number == 1)                // loops through the list and if the element matches 1 then remove it
            //        numbers.Remove(number);     // this code block will return an expection error! it cannot modify a collection in a foreach loop
                                                  // the .Remove(numbers) is the modify operation
            //}
            // IT CAN BE DONE IN A FOR LOOP

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[1]);
            }

            // Clear method

            numbers.Clear(); // removes all elements from the list
            Console.WriteLine("Count: " + numbers.Count);



        }
    }
}
