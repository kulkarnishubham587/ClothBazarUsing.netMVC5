using ClothBazar.Database;
using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClothBazar.Service
{
    public class CategoriesService
    {
        CBContext db = new CBContext();
        public void SaveCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public List<Category> ShowAllCategories()
        {
            return db.Categories.ToList();
        }


        public Category GetById(int id)
        {
            return db.Categories.Find(id);
        }

        public void EditCategory(Category category)
        {
            db.Entry(category).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Category category)
        {
            //db.Entry(category).State = System.Data.Entity.EntityState.Deleted; 
            db.Categories.Remove(category);
            db.SaveChanges();
        }
    }
}
