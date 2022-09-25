using Catalog.API.Entities;

namespace Catalog.API.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>>? GetProducts();

        Task<Product> GetProduct(string id);

        Task<bool> UpdateProduct(Product product);

        Task<Product> GetProductByName(string name);

        Task<Product> GetProductByCategory(string name);

        Task<bool> DeleteProduct(string id);

        Task CreateProduct(Product product);
    }
}
