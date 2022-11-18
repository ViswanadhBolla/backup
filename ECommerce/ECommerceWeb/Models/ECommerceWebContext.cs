using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using ECommerceWeb.Models;

namespace ECommerceWeb.Models
{
    public class ECommerceWebContext : DbContext
    {
        public ECommerceWebContext() 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderedProduct>()
                .HasKey(op => new { op.ProductId, op.CustomerOrderId });
            modelBuilder.Entity<LogonModel>().HasNoKey();
            modelBuilder.Entity<RegisterModel>().HasNoKey();
            modelBuilder.Entity<ChangePasswordModel>().HasNoKey();

        }
        public ECommerceWebContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<CustomerOrder> CustomerOrders { get; set; }

        public DbSet<OrderedProduct> Orderedproducts { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<ECommerceWeb.Models.LogonModel> LogonModel { get; set; }
    }
}
