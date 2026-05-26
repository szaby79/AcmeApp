using System;

try
{
    // Asks the user to enter their age.
    Console.WriteLine("Please enter your age:");

    // Stores the user's input.
    int age = Convert.ToInt32(Console.ReadLine());

    // Checks if the age is zero or negative.
    if (age <= 0)
    {
        // Throws an exception with a custom error message.
        throw new Exception("Age cannot be zero or negative.");
    }

    // Calculates the user's birth year.
    int birthYear = DateTime.Now.Year - age;

    // Displays the birth year.
    Console.WriteLine("You were born in approximately: " + birthYear);
}
catch (FormatException)
{
    // Displays an error message if the user enters invalid text.
    Console.WriteLine("Please enter a valid number.");
}
catch (Exception ex)
{
    // Displays a general error message for all other exceptions.
    Console.WriteLine(ex.Message);
}