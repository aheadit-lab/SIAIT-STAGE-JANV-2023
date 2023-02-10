using SIAITAPI.Data;
using SIAITAPI.IDAO;
using SIAITAPI.Models;

namespace SIAITAPI.DAO
{
    public class ProfilDAO : IProfilDAO
    {

        private ModelDbContext Context;
        public ProfilDAO(ModelDbContext context)
        {
            this.Context = context;
        }

        public IEnumerable<Profil> Get()
        {
            return this.Context.Profil.ToList();


        }

        public Profil Create(Profil profil)
        {
            profil.CreatedAt = DateTime.Now;
            profil.UpdatedAt = DateTime.Now;
            this.Context.Profil.Add(profil);
            this.Context.SaveChanges();
            return profil;
        }

        public Profil GetById(int id)
        {
            IQueryable<Profil> categories = this.Context.Profil.Where(c => c.Id == id);
            return categories.SingleOrDefault();
        }

        public Profil Update(Profil profil)
        {
            profil.UpdatedAt = DateTime.Now;
            this.Context.Profil.Update(profil);
            this.Context.SaveChanges();
            return profil;
        }

        public void Delete(int id)
        {
            Profil toDelete = this.Context.Profil.Where(x => x.Id == id).SingleOrDefault();
            if (toDelete == null)
                return;
            this.Context.Profil.Remove(toDelete);
            this.Context.SaveChanges();
        }
    }
}
