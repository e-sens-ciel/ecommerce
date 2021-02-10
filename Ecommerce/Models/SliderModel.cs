using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class SliderModel
    {
        List<Produit> _produit;

        public SliderModel()
        {
            Produit = new List<Produit>();
        }

        public List<Produit> Produit
        {
            get
            {
                return _produit;
            }

            set
            {
                _produit = value;
            }
        }
    }
}