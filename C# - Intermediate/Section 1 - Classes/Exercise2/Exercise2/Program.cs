﻿using System;
using System.Text;
namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Design a class called Post.
            //This class models a StackOverflow post.
            //It should have properties for title, description and the date/time it was created.
            //We should be able to up-vote or down-vote a post.
            //We should also be able to see the current vote value.
            //
            //In the main method, create a post, up-vote and down-vote it a few times and then display the the current vote value.
            //In this exercise, you will learn that a StackOverflow post should provide methods for up-voting and down-voting.
            //You should not give the ability to set the Vote property from the outside, because otherwise, you may accidentally change the votes of a class to 0 or to a random number.
            //
            //And this is how we create bugs in our programs. The class should always protect its
            //state and hide its implementation detail.
            //
            //Educational tip: The aim of this exercise is to help you understand that classes should
            //encapsulate data AND behaviour around that data. Many developers (even those with years of
            //experience) tend to create classes that are purely data containers, and other classes that are
            //purely behaviour (methods) providers.This is not object-oriented programming. This is
            //procedural programming. Such programs are very fragile.Making a change breaks many parts
            //of the code.

            string postTitle = "I'm a beginner and don't know about OOP encapsulation!!!!. Send help!";
            string postDescription = "What is the point of properties and constructors in a class? I just don't get it";
            Post makePost = new Post(postTitle, postDescription, DateTime.Now, 0);
            makePost.DisplyPost();

            do
            {
                Console.WriteLine("Type 'UP' to upvote\nType 'Down' to downvote");
                Console.WriteLine("Otherwise, type 'quit' to exit");
                string vote = Console.ReadLine();
                if (vote == "UP")
                {
                    makePost.ChangeVote(vote);
                }
                else if (vote == "DOWN")
                {
                    makePost.ChangeVote(vote);
                }
                else if (vote == "quit")
                {
                    break;
                }
                
            }
            while (true);
            Console.WriteLine("Number of Votes: " + makePost.myNumberOfVotes);
            
        }
    }
}
