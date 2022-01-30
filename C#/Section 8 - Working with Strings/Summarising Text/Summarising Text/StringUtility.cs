using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarising_Text
{
    public class StringUtility // public access modifier makes it available for the program.cs
    {
        public static string SummarizeText(string text, int maxLength = 25)
        {
            //const int maxLength = 20; // use of constants makes the code more readable
            if (text.Length < maxLength)
            {
                return text;
            }
            else
            {
                string[] words = text.Split(" "); // take all words separated by space and place as an element in array 
                int totalCharacters = 0;
                var summaryWord = new List<string>(); // init a string list 

                foreach (string word in words) // each word in the array is looped through
                {
                    summaryWord.Add(word); // add each word into a list
                    totalCharacters += word.Length + 1; // the length of each word is added to the totalCharacter variable with a +1 because of the space after each word
                    if (totalCharacters > maxLength) // check when the total character length reachs the maxLength then break
                        break;
                }
                string summary = String.Join(" ", summaryWord) + "...."; // the summary word list contains all the words before the break
                return summary;
            }
        }
    }
}
