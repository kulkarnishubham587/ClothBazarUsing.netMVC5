using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Entities
{
    public class Category:BaseEntity
    {

        //relationship
        public  List<Product> Products { get; set; }
    }
}
