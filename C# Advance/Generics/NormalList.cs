using System.Collections.Generic;
using System;
namespace Generics
{
    public class NormalList
    {
        public List<int> CreateList()
        {
            List<int> numbers = new List<int>(); // creates a list using type defined in the <> brackets
            List<int> output = new List<int>() { 1, 2, 3, 4, }; // example
            var example = new List<string>() { "one", "two", "three", "four" }; //we can initialize the list with values
            return output;
        }
    }
}
