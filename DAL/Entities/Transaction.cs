using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public char TransactionType { get; set; } // 'P' for Purchase, 'S' for Sale
        public string Notes { get; set; }

        public Product Product { get; set; }
    }
}
