using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace DAL
{
    public class InventoryManagementSystemContext:DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=InventoryManagementSystem;Integrated Security=true;TrustServerCertificate=True");


        public override int SaveChanges()
        {

            var Entities = from e in ChangeTracker.Entries()
                           where e.State == EntityState.Added ||
                           e.State == EntityState.Modified
                           select e.Entity;

            foreach(var entity in Entities)
            {
                ValidationContext validation = new ValidationContext(entity);
                Validator.ValidateObject(entity, validation, true);
            }

            return base.SaveChanges();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            /// By default the Primary key edited in Fluent API or by using Convention is Auto-incremented 
            
            modelBuilder.Entity<Product>().HasKey(p => p.ProductId);
            modelBuilder.Entity<Category>().HasKey(c => c.CategoryId);
            modelBuilder.Entity<Inventory>().HasKey(I => I.InventoryId);
            modelBuilder.Entity<Transaction>().HasKey(T => T.TransactionId);


            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Inventory>()
                .HasOne(i => i.Product)
                .WithOne()
                .HasForeignKey<Inventory>(i => i.ProductId);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Product)
                .WithMany()
                .HasForeignKey(t => t.ProductId);

            //// call base to not violate LISKOV ( change the Behaviour of the Base ( Parent ) ) 
            base.OnModelCreating(modelBuilder);
        }

    }
}
