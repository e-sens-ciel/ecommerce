using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class IndexViewModel
    {
        private List<SliderModel> _slider;
        private List<Produit> _produits;
        public IndexViewModel()
        {
            //Section Featured Product
            Slider = new List<SliderModel>();

            
            Produits = new List<Produit>();
            Produits.Add(new Produit() { Libellé = "Fond de teint", Prix = 40, Devise='$' });
            Produits.Add(new Produit() { Libellé = "Rouge à lèvres", Prix = 40, Devise = '$' });
            Produits.Add(new Produit() { Libellé = "Fard à paupières", Prix = 40, Devise = '$' });
            Produits.Add(new Produit() { Libellé = "Illuminateur", Prix = 40, Devise = '$' });
            Produits.Add(new Produit() { Libellé = "Palette contouring", Prix = 40, Devise = '$' });

        }

        public List<SliderModel> Slider
        {
            get
            {
                return _slider;
            }

            set
            {
                _slider = value;
            }
        }

        public List<Produit> Produits
        {
            get
            {
                return _produits;
            }

            set
            {
                _produits = value;
            }
        }
    }
}