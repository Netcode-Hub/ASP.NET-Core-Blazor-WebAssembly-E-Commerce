using BlazingShop.Shared;
using System.Net.Http.Json;

namespace BlazingShop.Client.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;
        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Product>>("api/products");
        }

        public async Task<IEnumerable<Product>> GetProductByCategoryId(int categoryId)
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Product>>($"api/products/{categoryId}");
        }
    }
}
