using System;

// Gets the current date and time.
DateTime currentTime = DateTime.Now;

// Prints the current date and time to the console.
Console.WriteLine("Current date and time: " + currentTime);

// Asks the user to enter a number.
Console.WriteLine("Please enter a number:");

// Stores the user's input.
string userInput = Console.ReadLine();

// Converts the user's input into an integer.
int hours = Convert.ToInt32(userInput);

// Adds the entered number of hours to the current time.
DateTime futureTime = currentTime.AddHours(hours);

// Prints the future time to the console.
Console.WriteLine("In " + hours + " hours, the time will be: " + futureTime);