using ClassesAndRecordsExample.Models;
using ClassesAndRecordsExample.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClassesAndRecordsExample.Controllers;

public class ProductController : Controller
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetAllProducts()
    {
        return Ok(await _productService.GetAllProducts());
    }
}