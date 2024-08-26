using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InventoryRepository : GenericRepository<Inventory>, IInventoryRepository
    {
       
        public InventoryRepository() :base() { }

        /// <summary>
        ///  Get Inventory state for a product using its id as a unique identifier
        /// </summary>
        /// <param name="productid"></param>
        /// <returns></returns>
        public async Task<Inventory>    GetInventoryByProductIdAsync(int productid) => await _context.Inventory.FirstOrDefaultAsync(I => I.ProductId == productid);

        
    }
}
