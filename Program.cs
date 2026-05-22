using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of integers
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };

            try
            {
                // Ask user for a number
                Console.WriteLine("Enter a number to divide by:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                // Loop through list and divide numbers
                foreach (int number in numbers)
                {
                    int result = number / userNumber;
                    Console.WriteLine(number + " divided by " + userNumber + " = " + result);
                }
            }
            catch (DivideByZeroException)
            {
                // Error if user enters 0
                Console.WriteLine("Error: You cannot divide by zero.");
            }
            catch (FormatException)
            {
                // Error if user enters text instead of number
                Console.WriteLine("Error: Please enter a valid number.");
            }
            catch (Exception ex)
            {
                // Any other error
                Console.WriteLine("Error: " + ex.Message);
            }

            // Program continues after try/catch
            Console.WriteLine("The program has continued past the try/catch block.");

            Console.ReadLine();
        }
    }
}