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

        public ActionResult ProductList()
        {

            return View();
        }
        public ActionResult ProductDetail()
        {

            return View();
        }
        public ActionResult Cart()
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
        //public ActionResult Login()
        //{
        //    //LoginViewModel lvm = new LoginViewModel();
        //    return View();
        //}

        public ActionResult Contact()
        {

            return View();
        }
    }
}