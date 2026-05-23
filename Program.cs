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
        employee.firstName = "Sample";

        // Set last name
        employee.lastName = "Student";

        // Call SayName method
        employee.SayName();

        // Keep console open
        Console.ReadLine();
    }
}