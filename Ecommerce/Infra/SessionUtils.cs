using Commerce.Models;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Infra
{
    public class SessionUtils
    {
        public static bool IsLogged
        {
            get
            {

                if (HttpContext.Current.Session["logged"] == null)
                {
                    HttpContext.Current.Session["logged"] = false;
                }
                return (bool)HttpContext.Current.Session["logged"];
            }

            set { HttpContext.Current.Session["logged"] = value; }
        }

        public static ClientModel ConnectedUser
        {
            get
            {
                return (ClientModel)HttpContext.Current.Session["ConnectedUser"];
            }

            set { HttpContext.Current.Session["ConnectedUser"] = value; }

        }

        public static ProduitModel Produit
        {
            get
            { 
                return (ProduitModel)HttpContext.Current.Session["cart"];
            }

            set
            { 
                HttpContext.Current.Session["cart"] = value; 
            }
        }
    }
}