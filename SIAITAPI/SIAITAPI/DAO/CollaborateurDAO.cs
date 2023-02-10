using SIAITAPI.Data;
using SIAITAPI.DTO;
using SIAITAPI.IDAO;
using SIAITAPI.Models;
using SIAITAPI.Utils;

namespace SIAITAPI.DAO
{
    public class CollaborateurDAO : ICollaborateurDAO
    {
        private ModelDbContext Context;
        public CollaborateurDAO(ModelDbContext context)
        {
            this.Context = context;
        }

        public IEnumerable<Collaborator> Get()
        {
            return this.Context.Collaborator.ToList();


        }

        public Collaborator Create(Collaborator Collaborateur)
        {
            Collaborateur.CreatedAt = DateTime.Now;
            Collaborateur.UpdatedAt = DateTime.Now;
            this.Context.Collaborator.Add(Collaborateur);
            this.Context.SaveChanges();
            return Collaborateur;
        }

        public Collaborator GetById(int id)
        {
            IQueryable<Collaborator> categories = this.Context.Collaborator.Where(c => c.Id == id);
            return categories.SingleOrDefault();
        }

        public Collaborator Update(Collaborator Collaborateur)
        {
            Collaborateur.UpdatedAt = DateTime.Now;
            this.Context.Collaborator.Update(Collaborateur);
            this.Context.SaveChanges();
            return Collaborateur;
        }

        public void Delete(int id)
        {
            Collaborator toDelete = this.Context.Collaborator.Where(x => x.Id == id).SingleOrDefault();
            if (toDelete == null)
                return;
            this.Context.Collaborator.Remove(toDelete);
            this.Context.SaveChanges();
        }



        public Collaborator Login(string username, string password)
        {
            var collaborator = this.Context.Collaborator.FirstOrDefault(x => x.UserName == username && x.Password == password);
          
                return collaborator;
           

        }

    }

    
}
