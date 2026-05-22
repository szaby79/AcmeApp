using System;

class MathClass
{
    // This void method takes two integers as parameters.
    public void DoMath(int firstNumber, int secondNumber)
    {
        // Do a math operation on the first integer.
        int result = firstNumber + 10;

        // Display the result of the math operation.
        Console.WriteLine("First number plus 10 = " + result);

        // Display the second integer to the screen.
        Console.WriteLine("Second number = " + secondNumber);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the class.
        MathClass math = new MathClass();

        // Call the method and pass in two numbers.
        math.DoMath(10, 5);

        // Call the method again, specifying the parameters by name.
        math.DoMath(firstNumber: 20, secondNumber: 8);

        // Keep the console open.
        Console.ReadLine();
    }
}