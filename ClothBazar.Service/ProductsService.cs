using ClothBazar.Database;
using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;


namespace ClothBazar.Service
{
    public class ProductsService
    {
        #region Singleton
        public static ProductsService Instance
        {
            get
            {
                if (PrivateInstance == null)
                    PrivateInstance = new ProductsService();
                return PrivateInstance;

            }
        }

        private static ProductsService PrivateInstance { get; set; }

        private ProductsService()
        {

        }
        #endregion
        public void SaveProduct(Product product)
        {  using (var db = new CBContext())
            {
                db.Entry(product.Category).State = System.Data.Entity.EntityState.Unchanged;
                db.products.Add(product);
                db.SaveChanges();
                
            }
        }

        public List<Product> ShowAllProducts()
        {
            using (var db = new CBContext())
            { return db.products.Include(x => x.Category).ToList();
            }
        }


        public Product GetById(int id)
        {
            using (var db = new CBContext()) {
                return db.products.Where(x => x.ID == id).Include(x => x.Category).FirstOrDefault();
            }
                
        }

        public void EditProduct(Product product)
        {
            using (var db = new CBContext())
            {
                db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (var db = new CBContext())
            {
                db.Entry(product).State = System.Data.Entity.EntityState.Deleted; 
               // db.products.Remove(product);
                db.SaveChanges();
            }
        }


        public List<Product> GetAllProductsByID(List<int> ids)
        {
            using (var db = new CBContext())
            {   
                return db.products.Where(product => ids.Contains(product.ID)).Include(x => x.Category).ToList();
            }

        }

    }
}
