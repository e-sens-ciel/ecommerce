using Commerce.DAL.Repositories;
using Commerce.Entities;
using Commerce.Models;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace Commerce.Repositories
{
    public class DataContext
    {
        IConcreteRepository<ProduitEntity> _produitRepo;
        IConcreteRepository<ClientEntity> _clientRepo;



        public DataContext(string connectionString)
        {
            _produitRepo = new ProduitRepository(connectionString);
            _clientRepo = new ClientRepository(connectionString);

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

        public List<ProduitModel> GetProduitSlider1()
        {

            return _produitRepo.Get()
             .Select(produitsFromDB =>
             new ProduitModel()
             {
                 Libellé = produitsFromDB.Libellé,
                 Prix = produitsFromDB.Prix,
                 Image = produitsFromDB.Image,
                 Devise = produitsFromDB.Devise
             }
             ).ToList();
         }

        public bool CreateUser(ClientModel um)
        {
            ClientEntity clientEntity = new ClientEntity()
            {
                Nom = um.Nom,
                Prenom = um.Prenom,
                Email = um.Email,
                MotDePasse = um.MotDePasse
            };

            return _clientRepo.Insert(clientEntity);
        }

        public ClientModel UserAuth(LoginModel lm)
        {
            ClientEntity ue = ((ClientRepository)_clientRepo).GetFromLogin(lm.Login);
            if (ue == null) return null;
            SecurityHelper sh = new SecurityHelper();
            if (sh.VerifyHash(lm.motDePasse, ue.MotDePasse, ue.Salt))
            {
                return new ClientModel()
                {
                    Email = ue.Email,
                    Nom = ue.Nom,
                    Prenom = ue.Prenom,
                };
            }
            else
            {
                return null;
            }
        }
    }
}
