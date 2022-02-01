using System;
using System.Text;

namespace StringBuilderDEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            //BONUS 
            // STRING BUILDER
            // defined in System.Text
            // mutable string 
            // easy and faste to create and modify on the fly
            // NOT optimize for seaching 
            // NO indexOf()
            // LastIndexOf()
            // Contains()
            // StartsWith()
            // etc
            // Instead it has good manipulation of strings
            // Append()
            // Insert()
            // Remove()
            // Replace()
            // Clear()

            var builder = new StringBuilder("Hello World"); // "Hello World" is the starting string
            builder.Append('-', 10); // writes - 10 times
            builder.AppendLine(); // new line
            builder.Append("Header"); // text 
            builder.AppendLine(); // new line 
            builder.Append('-', 10); // writes - 10 times
            // replace
            builder.Replace('-', '+');
            // remove
            builder.Remove(0, 10); // from index 0 to index 10
            //insert
            builder.Insert(0, new string ('-', 10)); // from index 0 add a new string of - 10x 
            Console.WriteLine(builder); // prints the above result

            //CLEANER WAY TO USE STRING BUILDER////

            var example = new StringBuilder("MASSIVE");
            example
                .Append('-', 10) // writes - 10 times
                .AppendLine() // new line
                .Append("EXAMPLE2") // text 
                .AppendLine() // new line 
                .Append('-', 10) // writes - 10 times
                .Replace('-', '+')
                .Remove(0, 10) // from index 0 to index 10
                .Insert(0, new string('-', 10)); // from index 0 add a new string of - 10x 
                Console.WriteLine(example); // prints the above result


        }
    }
}
