using ClothBazar.Database;
using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClothBazar.Service
{
    public class ProductsService
    {
        CBContext db = new CBContext();
        public void SaveProduct(Product product)
        {
            db.products.Add(product);
            db.SaveChanges();
        }

        public List<Product> ShowAllProducts()
        {
            return db.products.ToList();
        }


        public Product GetById(int id)
        {
            return db.products.Find(id);
        }

        public void EditProduct(Product product)
        {
            db.Entry(product).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Product product)
        {
            //db.Entry(category).State = System.Data.Entity.EntityState.Deleted; 
            db.products.Remove(product);
            db.SaveChanges();
        }
    }
}
