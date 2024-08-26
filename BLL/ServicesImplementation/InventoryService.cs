using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class InventoryService : IInventoryService
    {
        /// <summary>
        ///  Dependency Injection Propertey 
        /// </summary>
        private readonly InventoryRepository _inventoryrepository;
        public InventoryService()
        {
            _inventoryrepository = new InventoryRepository();
        }
        /// <summary>
        /// Get Inventory state for a product using its ID 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public async Task<Inventory> GetInventoryByProductIdAsync(int productId)
        {
            return await _inventoryrepository.GetInventoryByProductIdAsync(productId);
        }

        /// <summary>
        ///  a Method to Update each Product Inventory state after any transaction happened
        ///  quantity is negative incase fo Sales, and Positive incase of Purchase
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public async Task UpdateInventoryAsync(int productId, int quantity)
        {
            var inventory = await _inventoryrepository.GetInventoryByProductIdAsync(productId);

            if (inventory != null)
            {
                inventory.Quantity += quantity; // update by the new quantity 
                await _inventoryrepository.UpdateAsync(inventory);
            }
        }
    }
}
