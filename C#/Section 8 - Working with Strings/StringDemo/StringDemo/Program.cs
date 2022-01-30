using System;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Formatting
            // ToLower() - changes text to lower case
            // ToUpper() - changes text to upper case
            // Trim() - gets rid of white spaces between string
            // IndexOf('a) - searches for the index of a character or string
            // LastIndexOf("Hello") - searches the index of the occurance of a character or string
            // Substring(startIndex, length) - retrieves all character after a start index. Another overload includes a length parameter to limit the number of characters to retrieve
            // Replace('a','!') - replace character with another character in the string
            // String.isNullorEmpty(str) - checks if the string is empty
            // String.isNullorWhiteSpace(str) - checks if the string has white spaces
            // str.Split - returns an array of strings with words separated by " " space or "," comma or "|" pipe
            // int i = int.Parse(str) - parse a string number to an int type (throws expection if not number)
            // int j = Convert.ToInt32(str) - same as above, Parse string to int (returns zero if not number) Safer
            // string s = i.ToString() // converts an int type to a string type 
            // string s = i.ToString("C") // converts an int type to a string type with currency format $214
            // string s = i.ToString("C0") // converts an int type to a string type with currency format with 0 decimal
            // c or C = currency 123456(C) = $123,456
            // d or D = decimal  1234(D6) = 001234
            // e or E = exponential 1052.0329112756(E) = 1.052033E+003
            // f or F = fixed point 1234.56(F1) = 1234.5
            // x or X = hexadecimal 255(X) = FF

            string fullName = " Chris Yu "; // there is a space after Yu and before Chris, this is known as a whitespace
            Console.WriteLine("Trim: '{0}'" , fullName.Trim()); // whitespace is removed at the end and start of the string 
            Console.WriteLine("Trim && ToUpper: '{0}'", fullName.Trim().ToUpper()); // methods can be chained together

            // Separate the first and last name.
            // METHOD 1
            string fullName1 = "Chris Yu"; //removed the white space
            int index = fullName1.IndexOf(' ');
            // base one the index, a substring can be created. 
            string firstName = fullName1.Substring(0, index);
            string lastName = fullName1.Substring(index + 1);
            Console.WriteLine("METHOD 1 using ,Substring");
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            // METHOD 2
            string[] names = fullName1.Split(' ');
            Console.WriteLine("METHOD 2 using .Split");
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            // Replace
            string fullName2 = "Chris Yu"; //NOTE all string methods return new string so the original string in memory is not changed (immutable) 
            Console.WriteLine("Replace Chris with Christopher");
            //fullName2.Replace("Chris", "Christopher"); // replace a string with a string
            //fullName2.Replace("s", "S"); // replace low case s with upper case S
       
            Console.WriteLine(fullName2.Replace("Chris", "Christopher"));

            // Empty string or Null - validate inputs
            if (string.IsNullOrEmpty(""))  // checks if the parameter is null. The (null) or ("") gives an empty string
            {
                Console.WriteLine("Invalid1"); // null or "" empty will trigger the invalid
            }

            if (string.IsNullOrEmpty(" "))  // if a white space is used " " 
            {
                Console.WriteLine("Invalid2"); // " " white space does not trigger the invalid 
            }

            if (string.IsNullOrEmpty(" ".Trim()))  // a Trim can be used on the white space string to remove it  
            {
                Console.WriteLine("Invalid3"); // invalid will print this time as the white space is removed
            }

            //
            if (string.IsNullOrWhiteSpace(" "))  // new method added to skip the above
            {
                Console.WriteLine("Invalid4"); // " " white space does not trigger the invalid 
            }

            // covert string to int and vis versa
            // str to number
            string input = "25";
            //int age = Convert.ToInt32(input); // Method 1 - as the maximum possible age is around 100 the type can be changed to a byte
            int age = Convert.ToByte(input);
            Console.WriteLine("String to number type");
            Console.WriteLine(age);

            // number to str

            float price = 29.95f;
            string priceStr = price.ToString(); //.ToString is a method accessable by all object types
            Console.WriteLine("number to String");
            Console.WriteLine(price.ToString("C")); // formats the string to a currency

        }
    }
}
