using System;

// Employee class inherits from Person
public class Employee : Person
{
    // Implement abstract method
    public override void SayName()
    {
        Console.WriteLine("Name: " + firstName + " " + lastName);
    }
}