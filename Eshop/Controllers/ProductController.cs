using ClothBazar.Entities;
using ClothBazar.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eshop.Controllers
{
    public class ProductController : Controller
    {
        ProductsService productsService = new ProductsService();
        // GET: AllProduct
        public ActionResult Index()
        {
            return View( );
        }


        public ActionResult ProductTable()
        {
            var products = productsService.ShowAllProducts();
            return PartialView(products);
        }

        [HttpGet]
        public ActionResult Create()
        {

            return PartialView();
        }

        //create Category
        [HttpPost]
        public ActionResult Create(Product product)
        {
            productsService.SaveProduct(product);
            return RedirectToAction("ProductTable");
        }
 
    }
}