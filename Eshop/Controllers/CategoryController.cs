using ClothBazar.Database;
using ClothBazar.Entities;
using ClothBazar.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eshop.Controllers
{
    public class CategoryController : Controller
    {

        CategoriesService categoriesService = new CategoriesService();


        // get Category
        [HttpGet]
        public ActionResult Create()
        { 

            return View();
        }

        //create Category
        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoriesService.SaveCategory(category);
            return View();
        }
    }
}