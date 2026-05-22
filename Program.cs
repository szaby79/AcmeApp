using System;

// Class that contains math methods
class MathOperations
{
    // Method 1 - adds 10 to the number
    public int AddTen(int number)
    {
        return number + 10;
    }

    // Method 2 - multiplies the number by 2
    public int MultiplyByTwo(int number)
    {
        return number * 2;
    }

    // Method 3 - subtracts 5 from the number
    public int SubtractFive(int number)
    {
        return number - 5;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create object from MathOperations class
        MathOperations math = new MathOperations();

        // Ask user for a number
        Console.WriteLine("Enter a number:");

        // Read user input and convert to integer
        int userNumber = Convert.ToInt32(Console.ReadLine());

        // Call first method and display result
        int result1 = math.AddTen(userNumber);
        Console.WriteLine("Number plus 10 = " + result1);

        // Call second method and display result
        int result2 = math.MultiplyByTwo(userNumber);
        Console.WriteLine("Number multiplied by 2 = " + result2);

        // Call third method and display result
        int result3 = math.SubtractFive(userNumber);
        Console.WriteLine("Number minus 5 = " + result3);

        // Pause console window
        Console.ReadLine();
    }
}