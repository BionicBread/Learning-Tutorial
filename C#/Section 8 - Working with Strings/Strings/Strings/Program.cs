using System;

namespace Strings
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
        }
    }
}
