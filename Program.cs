using System;

// This class demonstrates constructor chaining.
public class ConstructorExample
{
    // Const variable that cannot be changed.
    public const string Species = "Human";

    // Property for the name.
    public string Name { get; set; }

    // Default constructor that chains to the second constructor.
    public ConstructorExample() : this("Unknown")
    {
    }

    // Constructor that accepts a name parameter.
    public ConstructorExample(string name)
    {
        // Assigns the parameter value to the Name property.
        Name = name;
    }
}

// This class contains the Main method.
class Program
{
    // This is the entry point of the program.
    static void Main(string[] args)
    {
        // Creates an object using the var keyword.
        var person = new ConstructorExample();

        // Prints the const variable.
        Console.WriteLine("Species: " + ConstructorExample.Species);

        // Prints the person's name.
        Console.WriteLine("Name: " + person.Name);
    }
}