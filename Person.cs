// Abstract Person class.
public abstract class Person
{
    // Property for first name.
    public string firstName { get; set; }

    // Property for last name.
    public string lastName { get; set; }

    // Abstract method that must be implemented in derived classes.
    public abstract void SayName();
}