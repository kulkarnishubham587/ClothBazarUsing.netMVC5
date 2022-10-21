using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eshop.ViewModels
{
    public class NewCategoryViewModel
    {
        public string Name { get; set; }
        public string ImgURL { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int CategoryID{ get; set; }

    }
}