namespace ClassesAndRecordsExample.Models;

public class Salesperson : Employee
{
    public int SalesMade { get; set; }

    public Salesperson(string name, int age, string department, int salesMade)
        : base(name, age, department)
    {
        SalesMade = salesMade;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Sales Made: {SalesMade}");
    }

    public override void Work()
    {
        Console.WriteLine("The salesperson is making sales calls.");
    }
}