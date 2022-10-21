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
         
        //CategoriesService categoriesService = new CategoriesService();


        [HttpGet]
        public ActionResult Index()
        {
             var listofcategory = CategoriesService.Instance.ShowAllCategories();
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
            CategoriesService.Instance.SaveCategory(category);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var category = CategoriesService.Instance.GetById(id);
            return View(category);
        }

        //Edit Category
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            CategoriesService.Instance.EditCategory(category);
            return RedirectToAction("Index");
        }

        //Delete 
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var category = CategoriesService.Instance.GetById(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Delete( Category category)
        { 
            var categories = CategoriesService.Instance.GetById(category.ID);
            CategoriesService.Instance.Delete(categories);
            return RedirectToAction("Index");
        }
    }
}