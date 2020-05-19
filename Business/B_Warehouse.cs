using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Warehouse
    {
        public List<WarehouseEntity> WareHouseList()
        {
            using (var db = new InventoryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public void CreateWareHouse(WarehouseEntity oWareHouse)
        {
            using (var db = new InventoryContext())
            {
                db.Add(oWareHouse);
                db.SaveChanges();
            }
        }

        public void UpdateWareHouse(WarehouseEntity oWareHouse)
        {
            using (var db = new InventoryContext())
            {
                db.Update(oWareHouse);
                db.SaveChanges();
            }
        }

        public void DeleteWareHouse(WarehouseEntity oWareHouse)
        {
            using (var db = new InventoryContext())
            {
                db.Remove(oWareHouse);
                db.SaveChanges();
            }
        }
    }
}
