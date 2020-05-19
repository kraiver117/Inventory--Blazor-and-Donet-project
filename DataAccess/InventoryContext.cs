using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventoryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }
        public DbSet<InputOutputEntity> InOuts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DESKTOP-6ECHJR7; Database=InventoryDb; User Id=sa;Password=12345");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName = "Aseo Hogar" },
                 new CategoryEntity { CategoryId = "ASP", CategoryName = "Aseo Personal" },
                  new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar" },
                   new CategoryEntity { CategoryId = "PRM", CategoryName = "Perfumeria" },
                    new CategoryEntity { CategoryId = "VDJ", CategoryName = "Video juegos" },
                     new CategoryEntity { CategoryId = "SLD", CategoryName = "Salud" },
                     new CategoryEntity { CategoryId = "ALT", CategoryName = "Alimentos" }
                );


            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity
                {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega central",
                    WarehouseAddress = "Corregidora #48"
                },
                new WarehouseEntity
                {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega Norte",
                    WarehouseAddress = "Zaragoza #35"
                },
                 new WarehouseEntity
                 {
                     WarehouseId = Guid.NewGuid().ToString(),
                     WarehouseName = "Bodega Oeste",

                     WarehouseAddress = "Amado Nervo #1203"
                 }


                );
        }


    }
}
