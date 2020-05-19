using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entities;

namespace Business
{
    public class B_Product
    {

        public List<ProductEntity> ProductList()
        {
            using (var db =  new InventoryContext())
            {
                return db.Products.ToList();
            }
        }

        public ProductEntity ProductById(string id)
        {
            using (var db = new InventoryContext())
            {
                return db.Products.ToList().LastOrDefault(p=>p.ProductId==id);
            }
        }

        public void CreateProduct(ProductEntity oProduct)
        {
            using (var db = new InventoryContext())
            {
                db.Add(oProduct);
                db.SaveChanges();
            }
        }

        public void UpdateProduct(ProductEntity oProduct)
        {
            using (var db = new InventoryContext())
            {
                db.Update(oProduct);
                db.SaveChanges();
            }
        }

        public void DeleteProduct(ProductEntity oProduct)
        {
            using (var db = new InventoryContext())
            {
                db.Remove(oProduct);
                db.SaveChanges();
            }
        }


    }
}
