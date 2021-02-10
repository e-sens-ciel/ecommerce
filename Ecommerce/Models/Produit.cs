﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Produit
    {
        #region Fields

        private string _libellé;
        private string _description;
        private double _prix;
        private double _quantiteDisponible;
        // IMAGE ? 
        private double _taxe;
        private char _devise;
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

        public char Devise
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
        #endregion
    }
}