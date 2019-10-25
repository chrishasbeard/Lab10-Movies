using System;
using System.Collections.Generic;

namespace Lab_10_Movie_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieTitle = new List<Movie>
            {
                new Movie("The Nightmare Before Christmas", "animated"),
                new Movie("Top Gun", "action"),
                new Movie("The Collector", "horror"),
                new Movie("Step Brothers", "comedy"),
                new Movie("Waiting", "comedy"),
                new Movie("Saw V", "horror"),
                new Movie("Kung Fury", "comedy"),
                new Movie("Kill Bill Vol. 1", "action"),
                new Movie("Dragon Ball Super: Broly", "animated"),
                new Movie("Die Hard","action")
            };

            Console.WriteLine("Welcome to my movie night! Let us check out my collection of movies.\n\n");
            for (int i = 0; i < movieTitle.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}) {movieTitle[i].Title} which is a {movieTitle[i].Category} movie.\n");
            }
           
            Console.WriteLine("\nWhat kind of movie category are in the mood for? (Comedy, Horror, Action, or Animated)");
            string suggestion = string.Empty;
            do
            {
                Console.WriteLine("\nSelect a category");
                suggestion = Console.ReadLine().ToLower();
                if (suggestion == "horror" || suggestion == "comedy" || suggestion == "animated" || suggestion == "action")
                {
                    for (int i = 0; i < movieTitle.Count; i++)
                    {
                        if (suggestion == movieTitle[i].Category)
                        {
                            Console.WriteLine($"\t{movieTitle[i].Title}\n");
                        }                        
                    }
                }
                else
                {
                    Console.WriteLine("\nthat is not a category I have. \n");
                }
               
            } while (GetOut());
            Console.WriteLine("\n\n\t\tDueces!");
        }
        public static bool GetOut()
        {
            Console.WriteLine("Would you like to see more movies? (y/n)");
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "y":
                    return true;
                case "n":
                    return false;
                default:
                    return GetOut();
            }
        }        
    }
}

