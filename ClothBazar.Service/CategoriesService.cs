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
    }
}
