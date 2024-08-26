using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TransactionRepository: GenericRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository() : base(){        }

        /// <summary>
        ///  Get All Transaction to A specific Product 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Transaction>> GetTransactionsByProductAsync(int productId)
        {
            return await _context.Transactions.Where(t => t.ProductId == productId).ToListAsync();
        }
    }
}
