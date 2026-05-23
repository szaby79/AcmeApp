using System;

// Main program class
class Program
{
    // Main method where the program starts
    static void Main(string[] args)
    {
        // Create Employee object
        Employee employee = new Employee();

        // Set first name
        employee.FirstName = "Sample";

        // Set last name
        employee.LastName = "Student";

        // Set ID
        employee.Id = 1;

        // Call inherited method
        employee.SayName();

        // Keep console open
        Console.ReadLine();
    }
}