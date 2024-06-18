namespace ClassesAndRecordsExample.Models;

public record ExternalCustomer(decimal Discount, string Name, string Email, string Phone) : SealedCustomer(Name, Email, Phone);