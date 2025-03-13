using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company_Project.Entities;
using Microsoft.EntityFrameworkCore;

namespace Company_Project.Context
{
    internal class AppDbContext: DbContext
    {
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplyOrder> SupplyOrders { get; set; }
        public DbSet<SupplyOrderItem> SupplyOrderItems { get; set; }
        public DbSet<ReleaseOrder> ReleaseOrders { get; set; }
        public DbSet<ReleaseOrderItem> ReleaseOrderItems { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Transfer> Transfers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Company_EF;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Call base method first to avoid conflicts
            base.OnModelCreating(modelBuilder);

            // Prevent cascading delete for Transfer -> SourceWarehouse
            modelBuilder.Entity<Transfer>()
                .HasOne(t => t.SourceWarehouse)
                .WithMany()
                .HasForeignKey(t => t.SourceWarehouseId)
                .OnDelete(DeleteBehavior.NoAction); // Prevents cascade delete

            // Prevent cascading delete for Transfer -> DestinationWarehouse
            modelBuilder.Entity<Transfer>()
                .HasOne(t => t.DestinationWarehouse)
                .WithMany()
                .HasForeignKey(t => t.DestinationWarehouseId)
                .OnDelete(DeleteBehavior.Restrict); // Prevents cycle errors

            // Prevent cascading delete for Item -> Warehouse relationship
            modelBuilder.Entity<Item>()
                .HasOne(i => i.Warehouse)
                .WithMany(w => w.Items) // Ensure Warehouse.Items collection exists
                .HasForeignKey(i => i.WarehouseId)
                .OnDelete(DeleteBehavior.Restrict); // Prevents multiple cascade paths
        }


    }
}
