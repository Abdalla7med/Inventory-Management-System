namespace DAL
{
    /// <summary>
    /// Just to follow the pattern, this interface isn't useful in this case, but it will be useful in-case of adding new logic 
    /// to the EntityRepository
    /// </summary>
    public interface IProductRepository : IRepository<Product>
    {
         Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId);

         Task<IEnumerable<Product>> GetProductsByNameAsync(string name);

         Task<IEnumerable<Product>> GetProductsByDescriptionAsync(string Description);

    }
}
