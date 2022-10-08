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


        [HttpGet]
        public ActionResult Index()
        {
             var listofcategory = categoriesService.ShowAllCategories();
            return View(listofcategory);
        }


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
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var category = categoriesService.GetById(id);
            return View(category);
        }

        //Edit Category
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoriesService.EditCategory(category);
            return RedirectToAction("Index");
        }
    }
}