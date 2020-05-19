using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore; //llamado para usar include

namespace Business
{
    public class B_Storage
    {
        public List<StorageEntity> StorageList()
        {
            using (var db = new InventoryContext())
            {
                return db.Storages.ToList();
            }
        }

        public void CreateStorage(StorageEntity oStorage)
        {
            using (var db = new InventoryContext())
            {
                db.Add(oStorage);
                db.SaveChanges();
            }
        }

        public bool IsProductInWareHouse(string IdStorage)
        {
            using (var db = new InventoryContext())
            {
                var product = db.Storages.ToList()
                    .Where(s => s.StorageId == IdStorage);

                return product.Any();
            }
        }

        public List<StorageEntity> StorageProductsByWarehouse(string idWarehouse)
        {
            using (var db = new InventoryContext())
            {
                return db.Storages
                    .Include(s => s.Product)
                    .Include(s => s.Warehouse)
                    .Where(s => s.WarehouseId==idWarehouse)
                    .ToList();
            }
        }

        public void UpdateStorage(StorageEntity oStorage)
        {
            using (var db = new InventoryContext())
            {
                db.Update(oStorage);
                db.SaveChanges();
            }
        }

        public void DeleteStorage(StorageEntity oStorage)
        {
            using (var db = new InventoryContext())
            {
                db.Remove(oStorage);
                db.SaveChanges();
            }
        }
    }
}
