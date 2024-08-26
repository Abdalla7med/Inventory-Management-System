using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ITransactionRepository : IRepository<Transaction> 
    {
        Task<IEnumerable<Transaction>> GetTransactionsByProductAsync(int productId);

    }
}
