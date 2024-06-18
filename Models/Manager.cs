namespace ClassesAndRecordsExample.Models;

public class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(string name, int age, string department, int teamSize)
        : base(name, age, department)
    {
        TeamSize = teamSize;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Team Size: {TeamSize}");
    }

    public override void Work()
    {
        Console.WriteLine("The manager is managing the team.");
    }
}