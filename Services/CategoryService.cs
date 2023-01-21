using BlazingShop.Shared;
using System.Net.Http.Json;

namespace BlazingShop.Client.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient httpClient;
        public CategoryService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Category>>("api/categories");
        }

        public async Task<Category> GetCategoryById(int categoryId)
        {
            return await httpClient.GetFromJsonAsync<Category>($"api/categories/{categoryId}");
        }
    }
}
