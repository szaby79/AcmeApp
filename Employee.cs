// Employee class inherits from Person and implements the IQuittable interface.
public class Employee : Person, IQuittable
{
    // This method implements the Quit method from the IQuittable interface.
    public void Quit()
    {
        // This line displays a message when the employee quits.
        Console.WriteLine(firstName + " " + lastName + " has quit the job.");
    }

    // This method displays the employee's full name.
    public override void SayName()
    {
        // This line prints the employee's first and last name.
        Console.WriteLine("Name: " + firstName + " " + lastName);
    }
}