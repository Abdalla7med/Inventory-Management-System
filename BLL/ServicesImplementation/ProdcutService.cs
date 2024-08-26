using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class ProductService : IProductService
    {

        /// <summary>
        ///  Dependency Injection Data Field to access database using DAL 
        /// </summary>

        private readonly ProductRepository _productrepository;

        /// <summary>
        ///  Initializing the datafield 
        /// </summary>
        public ProductService()
        {
            _productrepository = new ProductRepository();
        }
        /// <summary>
        /// Add a new Product 
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task AddProductAsync(Product product)
        {
             await _productrepository.AddAsync(product);
        }

        /// <summary>
        /// Delete a product from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteProductAsync(int id)
        {
            await _productrepository.DeleteAsync(id);
        }

        /// <summary>
        /// get product by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productrepository.GetByIdAsync(id);
        }

        /// <summary>
        /// get Products form the database
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _productrepository.GetAllAsync();
        }

        /// <summary>
        /// Get Product By Category, used in the case of filtration according to Category 
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>

        public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId)
        {
            return await _productrepository.GetProductsByCategoryAsync(categoryId);
        }

        /// <summary>
        /// Get Product By Description, used in the case of Searching using Description 
        /// </summary>
        /// <param name="Description"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> GetProductsByDescriptionAsync(string Description)
        {
            return await _productrepository.GetProductsByDescriptionAsync(Description);
        }

        /// <summary>
        ///  Get Product By Name 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> GetProductsByNameAsync(string name)
        {
            return await _productrepository.GetProductsByNameAsync(name);
        }

        /// <summary>
        /// Update product in the database according to some changes, may in the price or any other attribute 
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task UpdateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
