using ClassesAndRecordsExample.Data;
using ClassesAndRecordsExample.Models;
using ClassesAndRecordsExample.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IProductRepository, ProductRepository>();
builder.Services.AddSingleton<IProductService, ProductService>();

var app = builder.Build();

var product = new Product();
product.Name = "Smartphone red";

var productSerialized = ProductUtils.SerializeProduct(product);

string productString = "id: 1, name: Laptop, Description: High-performance laptop, price: 2500.00m, stock: 10";
var productDeserialized = ProductUtils.DeserializeProduct(productString);

var productNew = new Product()
{
    Name = "Smartphone red"
};

Product newProduct = new Product(1, "Laptop", "High-performance laptop", 2500.00m, 10);


var productDto = new ProductDto("Laptop", 1500.00m, "Electronics");

var productDtoModified = productDto with { Category = "Laptops" };

Address address = new Address("123 Main St", "Springfield", "IL", "62701");

var (street, city, state, zipCode) = address;
Console.WriteLine($"Street: {street}, City: {city}, State: {state}, ZipCode: {zipCode}");





var customer = new Customer("John Smith", "john@example.com", "95940033");

var internalCustomer = new InternalCustomer(10, "John Smith", "john@example.com", "95940033");





app.MapGet("/", () => "Hello World!");

app.Run();
