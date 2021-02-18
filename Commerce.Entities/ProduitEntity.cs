using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Entities
{
    public class ProduitEntity
    {
        #region Fields

        private string _libellé;
        private string _description;
        private double _prix;
        private double _quantiteDisponible;
        private string _image;
        private double _taxe;
        private string _devise;
        private DateTime _dateAjout;
        private string _eAN;
        #endregion

        #region Properties

        public string Libellé
        {
            get
            {
                return _libellé;
            }

            set
            {
                _libellé = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public double Prix
        {
            get
            {
                return _prix;
            }

            set
            {
                _prix = value;
            }
        }

        public double QuantiteDisponible
        {
            get
            {
                return _quantiteDisponible;
            }

            set
            {
                _quantiteDisponible = value;
            }
        }

        public double Taxe
        {
            get
            {
                return _taxe;
            }

            set
            {
                _taxe = value;
            }
        }

        public string Devise
        {
            get
            {
                return _devise;
            }

            set
            {
                _devise = value;
            }
        }

        public DateTime DateAjout
        {
            get
            {
                return _dateAjout;
            }

            set
            {
                _dateAjout = value;
            }
        }

        public string EAN
        {
            get
            {
                return _eAN;
            }

            set
            {
                _eAN = value;
            }
        }

        public string Image
        {
            get
            {
                return _image;
            }

            set
            {
                _image = value;
            }
        }
        #endregion
    }
}
