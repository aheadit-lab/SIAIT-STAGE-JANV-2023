using Microsoft.EntityFrameworkCore;
using SIAITAPI.Data;
using SIAITAPI.IDAO;
using SIAITAPI.Models;

namespace SIAITAPI.DAO
{
    public class ProfilActionDAO : IProfilActionDAO
    {

        private ModelDbContext Context;
        public ProfilActionDAO(ModelDbContext context)
        {
            this.Context = context;
        }

        public IEnumerable<ProfilAction> Get()
        {
            return this.Context.Profil_Action.ToList();


        }

        public ProfilAction Create(ProfilAction profilAction)
        {
            ProfilAction proxy = this.Context.Profil_Action.CreateProxy();
            profilAction.CreatedAt = DateTime.Now;
            profilAction.UpdatedAt = DateTime.Now;
            this.Context.Entry(proxy).CurrentValues.SetValues(profilAction);
           
            this.Context.Profil_Action.Add(proxy);
            this.Context.SaveChanges();
            return profilAction;
        }

       

        public ProfilAction GetById(int id)
        {
            IQueryable<ProfilAction> categories = this.Context.Profil_Action.Where(c => c.Id == id);
            return categories.SingleOrDefault();
        }

        public ProfilAction Update(ProfilAction ProfilAction)
        {
            ProfilAction.UpdatedAt = DateTime.Now;
            this.Context.Profil_Action.Update(ProfilAction);
            this.Context.SaveChanges();
            return ProfilAction;
        }

        public void Delete(int id)
        {
            ProfilAction toDelete = this.Context.Profil_Action.Where(x => x.Id == id).SingleOrDefault();
            if (toDelete == null)
                return;
            this.Context.Profil_Action.Remove(toDelete);
            this.Context.SaveChanges();
        }
    }
}
