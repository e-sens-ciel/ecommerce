using Commerce.DAL.Repositories;
using Commerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace Commerce.Repositories
{
    public class ClientRepository : BaseRepository<ClientEntity>, IConcreteRepository<ClientEntity>
    {

        public ClientRepository(string ConnectionString) : base(ConnectionString)
        {

        }

        public List<ClientEntity> Get()
        {
            return base.Get("Select * from Client");
        }

        public ClientEntity GetOne(int PK)
        {
            return base.GetOne(PK, "Select * from Client where Id_Client=@id");
        }

        public bool Insert(ClientEntity toInsert)
        {
            SecurityHelper securityHelper = new SecurityHelper();
            byte[] salt = securityHelper.GenerateLongRandomSalt();
            toInsert.Salt = Convert.ToBase64String(salt);
            toInsert.MotDePasse = securityHelper.createHash(toInsert.MotDePasse, salt);
            string requete = @"INSERT INTO [dbo].[Client]
           ([Nom]
           ,[Prenom]
           ,[Email]
           ,[MotDePasse]
           ,[Salt])
            VALUES
           (@Nom
           ,@Prenom 
           ,@Email
           ,@MotDePasse 
           ,@Salt)";
                
            return base.Insert(toInsert, requete);
        }

        public bool Update(ClientEntity toUpdate)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ClientEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public ClientEntity GetFromLogin(string login)
        {
            Dictionary<string, object> p = new Dictionary<string, object>();
            p.Add("login", login);
            return base.Get("Select * from [Client] where Email=@email", p).FirstOrDefault();
        }

    
    }


}