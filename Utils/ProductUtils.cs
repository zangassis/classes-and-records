using System.Text.Json;
using ClassesAndRecordsExample.Models;

namespace ClassesAndRecordsExample.Services;

public static class ProductUtils
{
    public static string SerializeProduct(Product product)
    {
        return JsonSerializer.Serialize(product);
    }

    public static Product DeserializeProduct(string json)
    {
        return JsonSerializer.Deserialize<Product>(json);
    }
}