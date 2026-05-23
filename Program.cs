// This creates an Employee object and stores it as an IQuittable type.
IQuittable employee = new Employee()
{
    firstName = "Sample",
    lastName = "Student"
};

// This calls the Quit method using polymorphism.
employee.Quit();