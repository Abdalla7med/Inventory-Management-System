using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{ 
    public interface IInventoryRepository : IRepository<Inventory>
    {

        Task<Inventory> GetInventoryByProductIdAsync(int productid);
    }
}
