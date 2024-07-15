public class Employee
{
    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor
    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    // Overload the == operator to compare Employees based on Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check if both objects are null or if they are the same instance
        if (ReferenceEquals(emp1, emp2))
            return true;

        // Check if either object is null, or if Ids are different
        if (emp1 is null || emp2 is null || emp1.Id != emp2.Id)
            return false;

        // Ids are the same
        return true;
    }

    // Overload the != operator to complement the ==
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }
}
