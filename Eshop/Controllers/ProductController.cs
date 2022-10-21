using ClothBazar.Entities;
using ClothBazar.Service;
using Eshop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eshop.Controllers
{
   // [Authorize(Roles ="Admin")]
    public class ProductController : Controller
    {
       
        //CategoriesService categoriesService = new CategoriesService();
        // GET: AllProduct
        public ActionResult Index()
        {
            var listofproducts = ProductsService.Instance.ShowAllProducts();
            return View(listofproducts);
        }

       

        [HttpGet]
        public ActionResult Create()
        {
            
            var categories = CategoriesService.Instance.ShowAllCategories();
            return View(categories);
        }

        //create product
        [HttpPost]
        public ActionResult Create(NewCategoryViewModel product)
        {
            
            Product newproduct = new Product();
            newproduct.Name = product.Name;
            newproduct.Description = product.Description;
            newproduct.Price = product.Price;
            if (product.ImgURL == null)
            {
                newproduct.ImgURL = "https://thumbs.dreamstime.com/b/no-image-available-icon-flat-vector-no-image-available-icon-flat-vector-illustration-132482953.jpg";
            }
            else
            newproduct.ImgURL = product.ImgURL;
            newproduct.Category = CategoriesService.Instance.GetById(product.CategoryID);
            ProductsService.Instance.SaveProduct(newproduct);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var category = ProductsService.Instance.GetById(id);
            return View(category);
        }

        //Edit Category
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            ProductsService.Instance.EditProduct(product);
            return RedirectToAction("Index");
        }

        //Delete 
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var product = ProductsService.Instance.GetById(id);
            ProductsService.Instance.Delete(product);
            TempData["AlertMessage"] = "product deleted...!";
            return RedirectToAction("Index");
        }

        /*[HttpPost]
        public ActionResult Delete(Product product)
        {
            var products = productsService.GetById(product.ID);
            productsService.Delete(products);
            return RedirectToAction("Index");
        }*/

    }
}