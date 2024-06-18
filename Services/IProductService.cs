using ClassesAndRecordsExample.Models;

namespace ClassesAndRecordsExample.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
    }
}