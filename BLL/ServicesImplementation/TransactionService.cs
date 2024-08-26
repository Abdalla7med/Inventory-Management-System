using DAL;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TransactionService : ITransactionService
    {
        /// <summary>
        /// data field to access data using Dependency Injection on the DAL  
        /// </summary>
        private readonly TransactionRepository _transactionRepository;

        /// <summary>
        ///  Data Field to get the Related data, and update it for each Product in the Inventory 
        /// </summary>
        private readonly InventoryService _inventoryservice;


        public TransactionService()
        {
            _transactionRepository = new TransactionRepository();
            _inventoryservice = new InventoryService();

        }

        /// <summary>
        ///  get all transactions in the Database for all products 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Transaction>>GetTransactionsAsync()  => await _transactionRepository.GetAllAsync();



        /// <summary>
        ///  returnn all transactions happened to a product using its Id as a identitifer 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>

        public async Task<IEnumerable<Transaction>> GetTransactionsByProductIdAsync(int productId) => await _transactionRepository.GetTransactionsByProductAsync(productId);
      
        
        /// <summary>
        /// Recode Purchase Transaction to a Specific Product 
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="quantity"></param>
        /// <param name="notes"></param>
        /// <returns></returns>

        public async Task RecordPurchaseAsync(int productId, int quantity, string notes)
        {
           await  _transactionRepository.AddAsync(new Transaction()
                   {
                        ProductId = productId,
                        Quantity = quantity,
                        Notes = notes,
                        TransactionDate = DateTime.Now,
                        TransactionType = 'P'
                   });

            await _inventoryservice.UpdateInventoryAsync(productId, quantity);

        }

        /// <summary>
        ///  Record Sales Transaction and if the Available Product Quantity in the Inventory isn't exceed or equals to the needed quantity, refuse the transaction 
        ///  else do the transaction, and update the inventory state
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="quantity"></param>
        /// <param name="notes"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>

        public async Task RecordSaleAsync(int productId, int quantity, string notes)
        {

            var inventory = await _inventoryservice.GetInventoryByProductIdAsync(productId);

            if (inventory.Quantity < quantity)
            {
                throw new InvalidOperationException("Insufficient stock.");
            }

            await _transactionRepository.AddAsync(
                  new Transaction()
                  {
                      ProductId = productId,
                      Quantity = quantity,
                      Notes = notes,
                      TransactionDate = DateTime.Now,
                      TransactionType = 'S'

                  });

            await _inventoryservice.UpdateInventoryAsync(productId, -quantity);

        }
    }
}
