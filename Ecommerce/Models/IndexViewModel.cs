using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class IndexViewModel
    {
        private List<SliderModel> _slider1;
        private List<Produit> _produits1;
        private List<Produit> _produits2;

        public IndexViewModel()
        {
            //Section Featured Product
            Slider1 = new List<SliderModel>();

            //Products for slider 1
            Produits1 = new List<Produit>();
            Produits1.Add(new Produit() { Libellé = "Fond de teint", Prix = 40, Devise='$', Image = "foundation.png" });
            Produits1.Add(new Produit() { Libellé = "Rouge à lèvres", Prix = 40, Devise = '$', Image = "rougealevre.png" });
            Produits1.Add(new Produit() { Libellé = "Fard à paupières", Prix = 40, Devise = '$', Image = "fardspaupiere.png" });
            Produits1.Add(new Produit() { Libellé = "Illuminateur", Prix = 40, Devise = '$', Image = "illuminateur.png" });
            Produits1.Add(new Produit() { Libellé = "Palette contouring", Prix = 40, Devise = '$', Image = "contouring.png" });


            //Products for slider 2
            Produits2 = new List<Produit>();
            Produits2.Add(new Produit() { Libellé = "Mascara", Prix = 40, Devise = '$', Image = "mascara.png" });
            Produits2.Add(new Produit() { Libellé = "Cheveux", Prix = 40, Devise = '$', Image = "cheveux-1.png" });
            Produits2.Add(new Produit() { Libellé = "Fards à paupières", Prix = 40, Devise = '$', Image = "fards-1.png" });
            Produits2.Add(new Produit() { Libellé = "Rouge à lèvres", Prix = 40, Devise = '$', Image = "lipstick-1.png" });

        }

        public List<SliderModel> Slider1
        {
            get
            {
                return _slider1;
            }

            set
            {
                _slider1 = value;
            }
        }

        public List<Produit> Produits1
        {
            get
            {
                return _produits1;
            }

            set
            {
                _produits1 = value;
            }
        }

        public List<Produit> Produits2
        {
            get
            {
                return _produits2;
            }

            set
            {
                _produits2 = value;
            }
        }
    }
}