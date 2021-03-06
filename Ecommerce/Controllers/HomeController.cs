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
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IndexViewModel ivm = new IndexViewModel();
            return View(ivm);
        }
        //public ActionResult Cart()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Cart(ProduitModel pm)
        //{
        //    //CartModel cm = new CartModel();
        //    //cm.produitsCarte.Add(pm);
        //    //CartViewModel cvm = new CartViewModel(cm);
        //    SessionUtils.Produit = pm;
        //    CartViewModel carte = new CartViewModel();

        //    return View(carte);

        //}
        public ActionResult ProductList()
        {
            Session["MessageInfo"] = "Hi bitch";

            return View();
        }
        public ActionResult ProductDetail()
        {

            return View();
        }
        public ActionResult Checkout()
        {

            return View();
        }
        public ActionResult MyAccount()
        {

            return View();
        }
        public ActionResult WishList()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }
    }
}