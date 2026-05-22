using System;

// Static class
static class MathHelper
{
    // Void method that divides a number by 2
    public static void DivideByTwo(int number)
    {
        int result = number / 2;

        // Display result to the screen
        Console.WriteLine("Result: " + result);
    }

    // Method with output parameter
    public static void GetSquare(int number, out int square)
    {
        square = number * number;
    }

    // Overloaded method with one parameter
    public static int AddNumbers(int number)
    {
        return number + 10;
    }

    // Overloaded method with two parameters
    public static int AddNumbers(int number1, int number2)
    {
        return number1 + number2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Ask user to enter a number
        Console.WriteLine("Enter a number:");

        // Convert user input to integer
        int userNumber = Convert.ToInt32(Console.ReadLine());

        // Call void method
        MathHelper.DivideByTwo(userNumber);

        // Call method with output parameter
        int squaredNumber;
        MathHelper.GetSquare(userNumber, out squaredNumber);

        // Display squared number
        Console.WriteLine("Squared number: " + squaredNumber);

        // Call overloaded method with one parameter
        int addResult1 = MathHelper.AddNumbers(userNumber);

        // Display result
        Console.WriteLine("Number plus 10: " + addResult1);

        // Call overloaded method with two parameters
        int addResult2 = MathHelper.AddNumbers(userNumber, 5);

        // Display result
        Console.WriteLine("Number plus 5: " + addResult2);

        // Keep console window open
        Console.ReadLine();
    }
}