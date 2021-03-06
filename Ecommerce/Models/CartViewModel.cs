using Commerce.Models;
using Commerce.Repositories;
using Ecommerce.Infra;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class CartViewModel
    {
        private DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
        public CartModel carteModele { get; set; }
        public ProduitModel produit { get; set; }
        public CartViewModel(int id)
        {
            //carteModele = cm;

            produit = ctx.GetProduit(id);


        }

    }
}