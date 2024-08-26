using DAL;

namespace BLL
{
    
        public interface IProductService
        {
            Task AddProductAsync(Product product);
            Task<Product> GetProductByIdAsync(int id);
            Task<IEnumerable<Product>> GetProductsAsync();
            Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId);
            Task UpdateProductAsync(Product product);
            Task DeleteProductAsync(int id);

            Task<IEnumerable<Product>> GetProductsByNameAsync(string name);

            Task<IEnumerable<Product>> GetProductsByDescriptionAsync(string Description);
        }

    
}
