using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Entities
{
    public class Product:BaseEntity
    {
    
        public double Price { get; set; }

        //relationship

        public virtual Category Category { get; set; }

    }
}
