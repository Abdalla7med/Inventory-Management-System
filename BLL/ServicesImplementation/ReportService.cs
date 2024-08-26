using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ReportService : IReportService
    {
        /// <summary>
        ///  Dependent Association, instead of inheritance
        /// </summary>
        private readonly CategoryRepository _categoryRepository; 
        private readonly InventoryRepository _inventoryRepository; 

        public ReportService()
        {
            this._inventoryRepository = new InventoryRepository();
            this._categoryRepository = new CategoryRepository();
        }


        public async Task<decimal> CalculateTotalInventoryValueAsync()
        {
            var inventory = await _inventoryRepository.GetAllAsync();
            return inventory.Sum(i => i.Quantity * i.Product.price);
        }

        public async Task<IEnumerable<dynamic>> GetCategoryWiseReportAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();

            return categories.Select(C => new
            {
                CategoryName = C.CategoryName,
                TotalValue = C.Products.Sum(p => p.price)
            });
           

        }

        public async Task<dynamic> GetInventoryReportAsync()
        {
            var Inventories = await _inventoryRepository.GetAllAsync();

            return Inventories.Select(In => new
            {
                Product = In.Product.Name,
                Quantity = In.Quantity,
                TotalPrice = In.Quantity * In.Product.price
            });
        }
    }
}
