using ClassesAndRecordsExample.Models;

namespace ClassesAndRecordsExample.Data;

public interface IProductRepository
{
    Task<List<Product>> GetAllProducts();
}