using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create three strings
            string firstString = "Hello";
            string secondString = "from";
            string thirdString = "C#";

            // Concatenate the three strings
            string fullString = firstString + " " + secondString + " " + thirdString;

            // Print concatenated string
            Console.WriteLine(fullString);

            // Convert string to uppercase
            string upperCaseString = fullString.ToUpper();

            // Print uppercase string
            Console.WriteLine(upperCaseString);

            // Create a StringBuilder
            StringBuilder paragraph = new StringBuilder();

            // Build paragraph sentence by sentence
            paragraph.Append("C# is a powerful programming language. ");
            paragraph.Append("It is used for building many types of applications. ");
            paragraph.Append("Learning C# can help create software and websites.");

            // Print the paragraph
            Console.WriteLine(paragraph);

            // Keep console window open
            Console.ReadLine();
        }
    }
}