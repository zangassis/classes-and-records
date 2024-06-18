namespace ClassesAndRecordsExample.Models;

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }

    public Employee(string name, int age, string department)
    {
        Name = name;
        Age = age;
        Department = department;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Department: {Department}");
    }

    public virtual void Work()
    {
        Console.WriteLine("The employee is working.");
    }
}