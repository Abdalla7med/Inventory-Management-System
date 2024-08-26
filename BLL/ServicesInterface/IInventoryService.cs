using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IInventoryService
    {
        Task<Inventory> GetInventoryByProductIdAsync(int productId);
        Task UpdateInventoryAsync(int productId, int quantity);
    }
}
