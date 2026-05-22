using System;

// Class that contains the math method
class MathOperations
{
    // Method with one required integer and one optional integer
    public int DoMath(int number1, int number2 = 5)
    {
        // Add the two numbers together
        return number1 + number2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create object from MathOperations class
        MathOperations math = new MathOperations();

        // Ask user for first number
        Console.WriteLine("Enter the first number:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        // Ask user for optional second number
        Console.WriteLine("Enter the second number (optional):");
        string secondInput = Console.ReadLine();

        // If user entered a second number
        if (secondInput != "")
        {
            // Convert second input to integer
            int secondNumber = Convert.ToInt32(secondInput);

            // Call method with two numbers
            int result = math.DoMath(firstNumber, secondNumber);

            // Display result
            Console.WriteLine("Result: " + result);
        }
        else
        {
            // Call method with only first number
            int result = math.DoMath(firstNumber);

            // Display result
            Console.WriteLine("Result: " + result);
        }

        // Pause console window
        Console.ReadLine();
    }
}