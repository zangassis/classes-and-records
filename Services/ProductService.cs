using ClassesAndRecordsExample.Data;
using ClassesAndRecordsExample.Models;

namespace ClassesAndRecordsExample.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<Product>> GetAllProducts()
    {
        return await _productRepository.GetAllProducts();
    }
}