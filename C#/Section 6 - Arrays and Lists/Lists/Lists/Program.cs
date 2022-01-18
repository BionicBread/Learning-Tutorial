using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // List is dynamic in size
            // using System.Collections.Generic THIS NEEDS TO BE DELCARED TO USE THE LIST CLASS

            List<int> list = new List<int>(); // Option 1 to init a list
            // List<int> list = new();         // Option 2 to init a list 
            List<int> known = new List<int>() {1,2,3,4,5,6,7,8}; // we can init a list with objects

            // known.Add the list class comes with useful methods
            // .Add - adds objects into the list
            // .AddRange - add a list of objects / array
            // .Remove - removes one object 
            // .RemoveAt - removes object at a given index
            // .IndexOf - returns the index of a given object
            // .Contains - tells if list contains a given object
            // .Count - returns the number of objects in a list

        }   
    }
}
