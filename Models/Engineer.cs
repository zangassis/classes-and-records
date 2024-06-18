namespace ClassesAndRecordsExample.Models;

public class Engineer : Employee
{
    public string Specialization { get; set; }

    public Engineer()
    {
    }

    public Engineer(string name, int age, string department, string specialization)
        : base(name, age, department)
    {
        Specialization = specialization;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Specialization: {Specialization}");
    }

    public override void Work()
    {
        Console.WriteLine("The engineer is working on a project.");
    }
}