

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DAL
{
    public class Product
    {
        public int ProductId { set; get; }

        [MaxLength(40), NotNull]
        public string Name { get; set; }
        
        public string Description { get; set; }
        [Precision(10,2)]
        public decimal price { set; get; }
        public int CategoryId { get; set; } // relatoin key 

        public Category Category { set; get; }   

    }
}