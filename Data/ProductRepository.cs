using ClassesAndRecordsExample.Models;

namespace ClassesAndRecordsExample.Data;

public class ProductRepository : IProductRepository
{
    public Task<List<Product>> GetAllProducts()
    {
        throw new NotImplementedException();
    }
}