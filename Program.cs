using System;
using System.Collections.Generic;
using System.Linq;

// Creates a list of employees.
List<Employee> employees = new List<Employee>()
{
    new Employee() { Id = 1, FirstName = "Joe", LastName = "Smith" },
    new Employee() { Id = 2, FirstName = "Joe", LastName = "Johnson" },
    new Employee() { Id = 3, FirstName = "Sarah", LastName = "Brown" },
    new Employee() { Id = 4, FirstName = "Mike", LastName = "Taylor" },
    new Employee() { Id = 5, FirstName = "Anna", LastName = "White" },
    new Employee() { Id = 6, FirstName = "David", LastName = "Clark" },
    new Employee() { Id = 7, FirstName = "Emily", LastName = "Hall" },
    new Employee() { Id = 8, FirstName = "Chris", LastName = "Allen" },
    new Employee() { Id = 9, FirstName = "Laura", LastName = "Young" },
    new Employee() { Id = 10, FirstName = "James", LastName = "King" }
};

// Creates a new list for employees named Joe using a foreach loop.
List<Employee> joeEmployees = new List<Employee>();

// Loops through all employees.
foreach (Employee employee in employees)
{
    // Checks if the employee's first name is Joe.
    if (employee.FirstName == "Joe")
    {
        // Adds the employee to the Joe list.
        joeEmployees.Add(employee);
    }
}

// Displays employees found with the foreach loop.
Console.WriteLine("Employees named Joe using foreach loop:");

foreach (Employee employee in joeEmployees)
{
    Console.WriteLine(employee.FirstName + " " + employee.LastName);
}

// Creates a new list of employees named Joe using a lambda expression.
List<Employee> joeLambda = employees.Where(x => x.FirstName == "Joe").ToList();

// Displays employees found with the lambda expression.
Console.WriteLine("Employees named Joe using lambda expression:");

foreach (Employee employee in joeLambda)
{
    Console.WriteLine(employee.FirstName + " " + employee.LastName);
}

// Creates a list of employees with Id greater than 5 using a lambda expression.
List<Employee> idGreaterThanFive = employees.Where(x => x.Id > 5).ToList();

// Displays employees with Id greater than 5.
Console.WriteLine("Employees with Id greater than 5:");

foreach (Employee employee in idGreaterThanFive)
{
    Console.WriteLine(employee.Id + " - " + employee.FirstName + " " + employee.LastName);
}