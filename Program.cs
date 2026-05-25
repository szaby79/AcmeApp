using System;
using System.IO;

// Asks the user to enter a number.
Console.WriteLine("Please enter a number:");

// Stores the user's input.
string userNumber = Console.ReadLine();

// Defines the file path.
string filePath = "numberLog.txt";

// Writes the user's number to the text file.
File.WriteAllText(filePath, userNumber);

// Reads the contents of the text file.
string fileContents = File.ReadAllText(filePath);

// Prints the contents of the text file to the console.
Console.WriteLine("The number in the text file is: " + fileContents);