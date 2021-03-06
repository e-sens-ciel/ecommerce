using Commerce.Models;
using Ecommerce.Infra;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CartId()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Cart(int id)
        {

            //CartModel cm = new CartModel(pm);
            //SessionUtils.Produit = pm;
            //CartViewModel carte = new CartViewModel(cm);
            CartViewModel cvm = new CartViewModel(id);
            return View(cvm);

        }



    }
}