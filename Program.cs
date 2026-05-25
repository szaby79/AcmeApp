using System;

// This struct stores a decimal number.
public struct Number
{
    // This property stores the amount value.
    public decimal Amount { get; set; }
}

// This class contains the Main method.
class Program
{
    // This is the entry point of the program.
    static void Main(string[] args)
    {
        // Creates an object of type Number.
        Number number = new Number();

        // Assigns a decimal value to the Amount property.
        number.Amount = 12.34m;

        // Prints the Amount value to the console.
        Console.WriteLine(number.Amount);
    }
}