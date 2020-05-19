using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_InOut
    {
        public List<InputOutputEntity> InOutList()
        {
            using (var db = new InventoryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void CreateInOut(InputOutputEntity oInOut)
        {
            using (var db = new InventoryContext())
            {
                db.Add(oInOut);
                db.SaveChanges();
            }
        }

        public void UpdateInOut(InputOutputEntity oInOut)
        {
            using (var db = new InventoryContext())
            {
                db.Update(oInOut);
                db.SaveChanges();
            }
        }

        public void DeleteInOut(InputOutputEntity oInOut)
        {
            using (var db = new InventoryContext())
            {
                db.Remove(oInOut);
                db.SaveChanges();
            }
        }
    }
}
