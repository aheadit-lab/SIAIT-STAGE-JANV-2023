using SIAITAPI.DAO;
using SIAITAPI.IDAO;
using SIAITAPI.IServices;
using SIAITAPI.Models;

namespace SIAITAPI.Services
{
    public class ProfilService : IProfilService
    {
        private IProfilDAO ProfilDAO;
        public ProfilService(IProfilDAO profilDAO)
        {
            ProfilDAO = profilDAO;
        }

        public Profil GetById(int id)
        {
            return ProfilDAO.GetById(id);
        }

        public Profil Update(int id, Profil Profil)
        {
            if (id != Profil.Id)
                throw new Exception("Not valid Id");
            else
                return ProfilDAO.Update(Profil);
        }

        public void Delete(int id)
        {
            ProfilDAO.Delete(id);
        }

        public IEnumerable<Profil> Get()
        {
            return ProfilDAO.Get();
        }


        public Profil Create(Profil Profil)
        {
            return ProfilDAO.Create(Profil);
        }


    }
}
