using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public interface ITransactionService
    {
        Task RecordPurchaseAsync(int productId, int quantity, string notes);
        Task RecordSaleAsync(int productId, int quantity, string notes);
        Task<IEnumerable<Transaction>> GetTransactionsAsync();
        Task<IEnumerable<Transaction>> GetTransactionsByProductIdAsync(int productId);

    }
}
