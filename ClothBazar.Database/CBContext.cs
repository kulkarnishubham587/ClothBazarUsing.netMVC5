using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Database
{
    public class CBContext : DbContext
    {
        public CBContext() : base()
        {
           
        }

        public DbSet<Product> products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
