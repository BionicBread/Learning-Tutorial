using System;
using System.Collections.Generic;

namespace Summarising_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            // Summarizing a large about of text
            // In blog previews only a certain amount of characters are displayed until there is a "....." 
            // This code will do this for a large amount of text 

            // Boundary text - this is the text that is displayed in the preview 

            var text = "This is going to be a really really really long text";
            var summary = StringUtility.SummarizeText(text, 30);
            Console.WriteLine(summary);
            //const int maxLength = 20; // use of constants makes the code more readable
            //if (sentence.Length < maxLength)
            //{
            //    Console.WriteLine(sentence);
            //}
            //else
            //{
            //    string[] words = sentence.Split(" "); // take all words separated by space and place as an element in array 
            //    int totalCharacters = 0;
            //    var summaryWord = new List<string>(); // init a string list 

            //    foreach (string word in words) // each word in the array is looped through
            //    {
            //        summaryWord.Add(word); // add each word into a list
            //        totalCharacters += word.Length + 1; // the length of each word is added to the totalCharacter variable with a +1 because of the space after each word
            //        if (totalCharacters > maxLength) // check when the total character length reachs the maxLength then break
            //            break;
            //    }
            //    string summary = String.Join(" ", summaryWord) + "...."; // the summary word list contains all the words before the break
            //    Console.WriteLine(summary);
         }
            // BEST PRACTICE IS TO PUT ALL THE ABOVE LOGIC INTO A CLASS and METHOD see StringUtility class

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
    }

}

