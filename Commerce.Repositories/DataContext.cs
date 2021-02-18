using Commerce.DAL.Repositories;
using Commerce.Entities;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Repositories
{
    public class DataContext
    {
        IConcreteRepository<ProduitEntity> _produitRepo;

        public DataContext(string connectionString)
        {
            _produitRepo = new ProduitRepository(connectionString);
        }

        public ProduitModel GetProduit()
        {
            ProduitEntity produitFromDB = _produitRepo.GetOne(1);
            ProduitModel produitForController = new ProduitModel();
            produitForController.Libellé = produitFromDB.Libellé;
            produitForController.Prix = produitFromDB.Prix;
            produitForController.Image = produitFromDB.Image;
            produitForController.Devise = produitFromDB.Devise;
            return produitForController;
        }
    }
}
