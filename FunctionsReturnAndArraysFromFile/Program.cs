using System;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string RandomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked: {RandomFood}");
        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "cola", "fanta", "sprite", "water" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string RandomDrinks = drinks[randomIndex];
            Console.WriteLine($"Computer picked: {RandomDrinks}");
        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "Die hard", "Die hard 2", "Die hard 3", "Die hard 4"};
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movies.Length);

            string RandomMovie = movies[randomIndex];
            Console.WriteLine($"Computer picked: {RandomMovie}");
        }
    }
}
