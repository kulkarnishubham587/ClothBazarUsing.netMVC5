using ClothBazar.Service;
using Eshop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eshop.Controllers
{
    public class ShopController : Controller
    {   CheckoutViewModels model = new CheckoutViewModels();
        
        // GET: Shop
        public ActionResult Checkout()
        { var CartProductCookie = Request.Cookies["CartProducts"];
            if (CartProductCookie != null)
            {
                model.CartProductIDs = CartProductCookie.Value.Split('-').Select(x => int.Parse(x)).ToList();
                model.CartProducts = ProductsService.Instance.GetAllProductsByID(model.CartProductIDs); 
            }

            return View(model);
        }
    }
}