using BlazingShop.Shared;

namespace BlazingShop.Client.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<IEnumerable<Product>> GetProductByCategoryId(int categoryId);
    }
}
