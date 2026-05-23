// Employee class with Id, FirstName, and LastName properties.
public class Employee
{
    // Employee ID property.
    public int Id { get; set; }

    // Employee first name property.
    public string FirstName { get; set; }

    // Employee last name property.
    public string LastName { get; set; }

    // Overloads the == operator to compare two Employee objects by Id.
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        // Returns true if both Employee objects have the same Id.
        return employee1.Id == employee2.Id;
    }

    // Overloads the != operator to compare two Employee objects by Id.
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        // Returns true if the Employee objects have different Id values.
        return employee1.Id != employee2.Id;
    }
}