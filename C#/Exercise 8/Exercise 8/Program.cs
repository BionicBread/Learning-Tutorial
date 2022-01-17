using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
            //If the user guesses the number, display “You won"; otherwise, display “You lost".
            //(To make sure the program is behaving correctly, you can display the secret number on the console first.)
            var random = new Random();          // Creates object for random generation
            int secret = random.Next(1, 10);    // Assign the random number to secret 
            int tries = 1;                      // Sets the try counter to 1
            string guess;                       // Declare the user input
            Console.WriteLine("Shhh! The secret number is " + secret);

            
            Console.WriteLine("Guess #" + tries + " Please enter a number between 1 to 10");
            guess = Console.ReadLine();
            int guessConvert = Int32.Parse(guess);  // Parse the string into an int
            while (guessConvert != secret)          // Loop will continue if the guess is NOT correct
            {
                tries++;                            // iterates the try counter by 1
                Console.WriteLine("Guess #" + tries + " Please enter a number between 1 to 10");
                guess = Console.ReadLine();         // Re-enter guess
                guessConvert = Int32.Parse(guess);  // Parse into int

                if (tries == 4)                     // Ends loops if try counter reaches 4
                    break;                          

            }
            if (guessConvert == secret)             // Print win message
            {
                Console.WriteLine("You Won!");
            }
            
            else if (tries == 4)                    // Print lose message
            {
                Console.WriteLine("You Lose!");
            }



            //if (guessConvert == secret)
            //{
            //    Console.WriteLine("You won");
            //}
            //Console.WriteLine("Try again");












        }
    }
}
