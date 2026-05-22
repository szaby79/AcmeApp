using System;

// Class that contains the math method
class MathClass
{
    // Void method that takes two integers as parameters
    public void MathOperation(int num1, int num2)
    {
        // Perform math operation on the first number
        int result = num1 + 7;

        // Display the result of the first number
        Console.WriteLine("First number plus 7 = " + result);

        // Display the second number
        Console.WriteLine("Second number = " + num2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the class
        MathClass math = new MathClass();

        // Call the method normally
        math.MathOperation(10, 5);

        // Call the method using named parameters
        math.MathOperation(num1: 20, num2: 8);

        // Keep console window open
        Console.ReadLine();
    }
}