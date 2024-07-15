using System;

class Program
{
    static void Main()
    {
        // Create two Employee objects
        Employee emp1 = new Employee(1, "Tuka", "Araibi");
        Employee emp2 = new Employee(2, "Jen", "Shii");

        // Compare using overloaded operator ==
        bool areEqual = emp1 == emp2;

        // Display the comparison result
        if (areEqual)
            Console.WriteLine("Employees are equal based on Id.");
        else
            Console.WriteLine("Employees are not equal based on Id.");

        // Keep the console window open until a key is pressed
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
