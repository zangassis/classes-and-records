namespace ClassesAndRecordsExample.Models;

public record ResidentialAddress(string ResidentName, string Street, string City, string State, string ZipCode) :
CustomerAddress(Street, City, State, ZipCode);
