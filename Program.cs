// Creates the first Employee object and assigns values to its properties.
Employee employee1 = new Employee()
{
    Id = 1,
    FirstName = "Sample",
    LastName = "Student"
};

// Creates the second Employee object and assigns values to its properties.
Employee employee2 = new Employee()
{
    Id = 2,
    FirstName = "Test",
    LastName = "Employee"
};

// Compares the two Employee objects using the overloaded == operator.
Console.WriteLine("Are the employees equal? " + (employee1 == employee2));

// Compares the two Employee objects using the overloaded != operator.
Console.WriteLine("Are the employees not equal? " + (employee1 != employee2));