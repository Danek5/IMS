using IMS.CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Plugins.EFCore
{
    public class IMSContext : DbContext
    {
        public IMSContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductInventory>().HasKey(pi => new { pi.ProductId, pi.InventoryId});
            modelBuilder.Entity<ProductInventory>().HasOne(pi => pi.Product).WithMany(p => p.ProductInventories).HasForeignKey(pi => pi.ProductId);
            modelBuilder.Entity<ProductInventory>().HasOne(pi => pi.Product).WithMany(i => i.ProductInventories).HasForeignKey(pi => pi.InventoryId);

            modelBuilder.Entity<Inventory>().HasData(
            new Inventory { InventoryId = 1, InventoryName = "Electonics", Price = 22, Quantity = 100 },
            new Inventory { InventoryId = 2, InventoryName = "Fruits", Price = 222, Quantity = 100 },
            new Inventory { InventoryId = 3, InventoryName = "Meat", Price = 220, Quantity = 100 },
            new Inventory { InventoryId = 4, InventoryName = "Body", Price = 122, Quantity = 100 },
            new Inventory { InventoryId = 5, InventoryName = "Engine", Price = 2, Quantity = 10 },
            new Inventory { InventoryId = 6, InventoryName = "Chase", Price = 2000, Quantity = 10 },
            new Inventory { InventoryId = 7, InventoryName = "Batery", Price = 2000, Quantity = 17 }

            );

            modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, ProductName = "Bike", Price = 22, Quantity = 100 },
            new Product { ProductId = 2, ProductName = "Banana", Price = 222, Quantity = 100 },
            new Product { ProductId = 3, ProductName = "Beef", Price = 220, Quantity = 100 }
            );

            modelBuilder.Entity<ProductInventory>().HasData(
                new ProductInventory { ProductId = 1, InventoryId = 1, InventoryQuntity = 1 },
                new ProductInventory { ProductId = 1, InventoryId = 2, InventoryQuntity = 1 },
                new ProductInventory { ProductId = 1, InventoryId = 3, InventoryQuntity = 4 },
                new ProductInventory { ProductId = 1, InventoryId = 4, InventoryQuntity = 5 }
            );

            modelBuilder.Entity<ProductInventory>().HasData(
                new ProductInventory { ProductId = 2, InventoryId = 5, InventoryQuntity = 1 },
                new ProductInventory { ProductId = 2, InventoryId = 2, InventoryQuntity = 1 },
                new ProductInventory { ProductId = 2, InventoryId = 3, InventoryQuntity = 4 },
                new ProductInventory { ProductId = 2, InventoryId = 4, InventoryQuntity = 5 }
            );

        }
    }
}
