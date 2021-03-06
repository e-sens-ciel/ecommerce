using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Models
{
    public class CartModel
    {
        public int CartId { get; set; }
        public string Libellé { get; set; }
        public int Quantite { get; set; }
        public double Prix { get; set; }
        public string Image { get; set; }
        public string  Devise { get; set; }
        public double Total { get; set; }
        public CartModel()
        {
            //Libellé = pm.Libellé;
            //Prix = pm.Prix;
            //Image = pm.Image;
            //Devise = pm.Devise;
        }
    }
}
