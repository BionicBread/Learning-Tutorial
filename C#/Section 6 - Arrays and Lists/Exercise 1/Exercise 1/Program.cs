using System;
using System.Collections.Generic;

namespace Exercise_1
{

    class Program
    {
        static void Main(string[] args)
        {
            // When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            // If no one likes your post, it doesn't display anything.
            // If only one person likes your post, it displays: [Friend's Name] likes your post.
            // If two people like your post, it displays:[Friend 1] and[Friend 2] like your post.
            // If more than two people like your post, it displays:[Friend 1], [Friend 2] and[Number of Other People] others like your post.

            //Write a program and continuously ask the user to enter different names, until the user presses Enter(without supplying a name).
            //Depending on the number of names provided, display a message based on the above pattern.

            // Loop for entering names until null is entered

            
            List<string> names = new List<string>();        // init a list
            string input;
            do
            {
                Console.WriteLine("Type a name");
                input = Console.ReadLine();                     
                names.Add(input);                           // adds input into list
                //foreach (string n in names)               // checks list element 
                //    Console.WriteLine(n);
            } while (!String.IsNullOrEmpty(input));         // no name entered will end name input loop
            
            switch (names.Count)                            // apply like message logic
            {
                case <= 1:   // Zero people                                                                                             
                    break;
                case <= 2:   // one like
                    Console.WriteLine(names[0]+ " likes your post!");
                    break;
                case <= 3:   // two likes
                    Console.WriteLine(names[0] + " and " + names[1] + " like your post!");
                    break;
                case >= 4:  // more than 2
                    Console.WriteLine(names[0]+ ", " + names[1] + " and " + (names.Count-3) + " others like your post!");
                    break;
            }
        }
    }
}
