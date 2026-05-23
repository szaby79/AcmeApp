using System;

// Abstract Person class
public abstract class Person
{
    // First name property
    public string firstName { get; set; }

    // Last name property
    public string lastName { get; set; }

    // Abstract method
    public abstract void SayName();
}