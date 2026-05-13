using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Ask for package weight
        Console.WriteLine("Please enter the package weight:");
        int weight = Convert.ToInt32(Console.ReadLine());

        // Check if package is too heavy
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        }
        else
        {
            // Ask for package width
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            // Ask for package height
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            // Ask for package length
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // Add dimensions together
            int totalDimensions = width + height + length;

            // Check if package is too big
            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                // Calculate shipping quote
                decimal quote = (width * height * length * weight) / 100m;

                // Display quote
                Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                Console.WriteLine("Thank you!");
            }
        }

        Console.ReadLine();
    }
}