using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of strings
            string[] fruits = { "Apple", "Banana", "Orange", "Grapes" };

            // Ask user for index
            Console.WriteLine("Choose an index for the fruit array (0-3):");
            int fruitIndex = Convert.ToInt32(Console.ReadLine());

            // Check if index exists
            if (fruitIndex >= 0 && fruitIndex < fruits.Length)
            {
                Console.WriteLine("Fruit: " + fruits[fruitIndex]);
            }
            else
            {
                Console.WriteLine("That index does not exist.");
            }

            // Array of integers
            int[] numbers = { 10, 20, 30, 40, 50 };

            // Ask user for index
            Console.WriteLine("Choose an index for the number array (0-4):");
            int numberIndex = Convert.ToInt32(Console.ReadLine());

            // Check if index exists
            if (numberIndex >= 0 && numberIndex < numbers.Length)
            {
                Console.WriteLine("Number: " + numbers[numberIndex]);
            }
            else
            {
                Console.WriteLine("That index does not exist.");
            }

            // List of strings
            List<string> colors = new List<string>()
            {
                "Red",
                "Blue",
                "Green",
                "Yellow"
            };

            // Ask user for index
            Console.WriteLine("Choose an index for the color list (0-3):");
            int colorIndex = Convert.ToInt32(Console.ReadLine());

            // Check if index exists
            if (colorIndex >= 0 && colorIndex < colors.Count)
            {
                Console.WriteLine("Color: " + colors[colorIndex]);
            }
            else
            {
                Console.WriteLine("That index does not exist.");
            }

            Console.ReadLine();
        }
    }
}