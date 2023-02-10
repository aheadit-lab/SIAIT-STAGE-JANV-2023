using SIAITAPI.DAO;
using SIAITAPI.IDAO;
using SIAITAPI.IServices;
using SIAITAPI.Models;

namespace SIAITAPI.Services
{
    public class ProfilMenuService : IProfilMenuService
    {
        private IProfilMenuDAO ProfilMenuDAO;
        public ProfilMenuService(IProfilMenuDAO profilMenuDAO)
        {
            ProfilMenuDAO = profilMenuDAO;
        }

        public ProfilMenu GetById(int id)
        {
            return ProfilMenuDAO.GetById(id);
        }

        public ProfilMenu Update(int id, ProfilMenu ProfilMenu)
        {
            if (id != ProfilMenu.Id)
                throw new Exception("Not valid Id");
            else
                return ProfilMenuDAO.Update(ProfilMenu);
        }

        public void Delete(int id)
        {
            ProfilMenuDAO.Delete(id);
        }

        public IEnumerable<ProfilMenu> Get()
        {
            return ProfilMenuDAO.Get();
        }


        public ProfilMenu Create(ProfilMenu ProfilMenu)
        {
            return ProfilMenuDAO.Create(ProfilMenu);
        }


    }
}
