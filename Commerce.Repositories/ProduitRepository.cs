using Commerce.DAL.Repositories;
using Commerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Repositories
{
    public class ProduitRepository : BaseRepository<ProduitEntity>, IConcreteRepository<ProduitEntity>
    {
        public ProduitRepository(string connectionString) : base(connectionString)
        {
        }

        public List<ProduitEntity> Get()
        {
            string requete = "Select * from Produit";
            return base.Get(requete);
        }

        public ProduitEntity GetOne(int PK)
        {
            string requete = "Select * from Produit where Id_Produit = @id";

            return base.GetOne(PK, requete);
        }

        public bool Insert(ProduitEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProduitEntity toUpdate)
        {
            throw new NotImplementedException();
        }
        public bool Delete(ProduitEntity toDelete)
        {
            throw new NotImplementedException();
        }
    }
}
