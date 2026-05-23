using System;

// Person class
public class Person
{
    // First name property
    public string FirstName { get; set; }

    // Last name property
    public string LastName { get; set; }

    // Method that displays full name
    public void SayName()
    {
        Console.WriteLine("Name: " + FirstName + " " + LastName);
    }
}