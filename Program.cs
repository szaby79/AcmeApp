using System;

// Enum for the days of the week.
DaysOfWeek currentDay;

try
{
    // Prompts the user to enter the current day of the week.
    Console.WriteLine("Enter the current day of the week:");

    // Stores the user's input.
    string userInput = Console.ReadLine();

    // Converts the user's input into the enum data type.
    currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

    // Displays the successfully parsed day.
    Console.WriteLine("You entered: " + currentDay);
}
catch
{
    // Displays an error message if the user enters an invalid day.
    Console.WriteLine("Please enter an actual day of the week.");
}

// Enum for the days of the week.
public enum DaysOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}