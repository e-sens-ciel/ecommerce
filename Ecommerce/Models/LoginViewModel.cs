using Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class LoginViewModel
    {
        public LoginModel LoginModel { get; set; }
        public ClientModel ClientModel { get; set; }
    }
}