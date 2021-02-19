using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Models
{
    public class ClientModel
    {
        #region Fields
        private string _nom;
        private string _prenom;
        private string _email;
        private string _motDePasse;
        private string _confirmermdp;
        private string _login;
        #endregion

        #region Properties
        [Required]
        [MaxLength(50)]
        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }
        [Required]
        [MaxLength(50)]

        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                _prenom = value;
            }
        }

        [Required]
        [MaxLength(50)]
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string MotDePasse
        {
            get
            {
                return _motDePasse;
            }

            set
            {
                _motDePasse = value;
            }
        }

        public string Login
        {
            get
            {
                return _login;
            }

            set
            {
                _login = value;
            }
        }

        [Required]
        [MaxLength(50)]
        [Compare("Password", ErrorMessage = "Les mot de passe ne correspondent pas")]
        public string Confirmermdp
        {
            get
            {
                return _confirmermdp;
            }

            set
            {
                _confirmermdp = value;
            }
        }

        #endregion
    }
}
