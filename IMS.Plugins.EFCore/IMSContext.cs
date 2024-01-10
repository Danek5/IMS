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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>().HasData(
            new Inventory { InventoryId = 1, InventoryName = "Electonics", Price = 22, Quantity = 100 },
            new Inventory { InventoryId = 2, InventoryName = "Fruits", Price = 222, Quantity = 100 },
            new Inventory { InventoryId = 3, InventoryName = "Meat", Price = 220, Quantity = 100 },
            new Inventory { InventoryId = 4, InventoryName = "Body", Price = 122, Quantity = 100 },
            new Inventory { InventoryId = 5, InventoryName = "Engine", Price = 2, Quantity = 100 }
            );
        }
    }
}
