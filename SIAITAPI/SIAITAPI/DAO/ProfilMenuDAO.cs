using Microsoft.EntityFrameworkCore;
using SIAITAPI.Data;
using SIAITAPI.IDAO;
using SIAITAPI.Models;

namespace SIAITAPI.DAO
{
    public class ProfilMenuDAO : IProfilMenuDAO
    {

        private ModelDbContext Context;
        public ProfilMenuDAO(ModelDbContext context)
        {
            this.Context = context;
        }

        public IEnumerable<ProfilMenu> Get()
        {
            return this.Context.Profil_Menu.ToList();


        }

        public ProfilMenu Create(ProfilMenu profilMenu)
        {
            ProfilMenu proxy = this.Context.Profil_Menu.CreateProxy();
            profilMenu.CreatedAt = DateTime.Now;
            profilMenu.UpdatedAt = DateTime.Now;
            this.Context.Entry(proxy).CurrentValues.SetValues(profilMenu);

            this.Context.Profil_Menu.Add(proxy);
            this.Context.SaveChanges();
            return profilMenu;
        }

        public ProfilMenu GetById(int id)
        {
            IQueryable<ProfilMenu> categories = this.Context.Profil_Menu.Where(c => c.Id == id);
            return categories.SingleOrDefault();
        }

        public ProfilMenu Update(ProfilMenu profilMenu)
        {
            profilMenu.UpdatedAt = DateTime.Now;
            this.Context.Profil_Menu.Update(profilMenu);
            this.Context.SaveChanges();
            return profilMenu;
        }

        public void Delete(int id)
        {
            ProfilMenu toDelete = this.Context.Profil_Menu.Where(x => x.Id == id).SingleOrDefault();
            if (toDelete == null)
                return;
            this.Context.Profil_Menu.Remove(toDelete);
            this.Context.SaveChanges();
        }
    }
}
