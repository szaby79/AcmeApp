using System;

// Class that contains overloaded methods
class MathOperations
{
    // Method that accepts an integer
    public int DoMath(int number)
    {
        // Add 10 to the integer
        return number + 10;
    }

    // Method that accepts a decimal
    public int DoMath(decimal number)
    {
        // Multiply decimal by 2 and convert to int
        return Convert.ToInt32(number * 2);
    }

    // Method that accepts a string
    public int DoMath(string number)
    {
        // Convert string to integer
        int convertedNumber = Convert.ToInt32(number);

        // Subtract 5 from the converted integer
        return convertedNumber - 5;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create object from MathOperations class
        MathOperations math = new MathOperations();

        // Call method with integer
        int intResult = math.DoMath(10);
        Console.WriteLine("Integer result: " + intResult);

        // Call method with decimal
        int decimalResult = math.DoMath(12.5m);
        Console.WriteLine("Decimal result: " + decimalResult);

        // Call method with string
        int stringResult = math.DoMath("20");
        Console.WriteLine("String result: " + stringResult);

        // Pause console window
        Console.ReadLine();
    }
}