namespace ClassesAndRecordsExample.Models;

public record InternalCustomer(decimal Discount, string Name, string Email, string Phone) :
Customer(Name, Email, Phone);