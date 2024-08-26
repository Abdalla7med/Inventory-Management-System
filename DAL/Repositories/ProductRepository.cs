using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace DAL
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        
        /// <summary>
        ///  Chain on the Class CTOR with the Context of the InventoryManagement System
        ///  I Could make it by default inside the Generic Repository is the IMS Context 
        ///  but to add some of Generics 
        /// </summary>
       
        public ProductRepository():base()
        {
           
        }


        /// <summary>
        ///  This for the use of Filtration using Category
        ///  and Implemented using Implicit Interface Implementation 
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>

        public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId)
        {
            return await _context.Products.Where(p => p.CategoryId == categoryId).ToListAsync();
        }
        /// <summary>
        /// To Filter Prodcut By the Name 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> GetProductsByNameAsync(string name)
        {
            return await _context.Products.Where(p => p.Name == name).ToListAsync();
        }

        /// <summary>
        ///  To Filter Product  by the Description 
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> GetProductsByDescriptionAsync(string description)
        {
            return await _context.Products.Where(p => p.Description == description).ToListAsync();
        }


    }
}
