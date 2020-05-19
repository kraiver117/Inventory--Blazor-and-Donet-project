using Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business
{
    public class B_Category
    {
        public List<CategoryEntity> CategoryList()
        {
            using (var db = new InventoryContext())
            {
                return db.Categories.ToList();
            } ///Al finalizar  este bloque cierra la conexión a la base de datos
        }

        public void CreateCategory(CategoryEntity oCategory)
        {
            using (var db=new InventoryContext())
            {
                db.Categories.Add(oCategory);
                db.SaveChanges();
            }
        }


        public void UpdateCategory(CategoryEntity oCategory)
        {
            using (var db=new InventoryContext())
            {
                db.Categories.Update(oCategory);
                db.SaveChanges();
            }
        }

        public void DeleteCategory(CategoryEntity oCategory)
        {
            using (var db=new InventoryContext())
            {
                db.Categories.Remove(oCategory);
                db.SaveChanges();
            }
        }


    }
}
