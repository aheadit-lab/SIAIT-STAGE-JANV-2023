using SIAITAPI.DAO;
using SIAITAPI.IDAO;
using SIAITAPI.IServices;
using SIAITAPI.Models;

namespace SIAITAPI.Services
{
    public class ProfilActionService : IProfilActionService
    {
        private IProfilActionDAO ProfilActionDAO;
        public ProfilActionService(IProfilActionDAO profilActionDAO)
        {
            ProfilActionDAO = profilActionDAO;
        }

        public ProfilAction GetById(int id)
        {
            return ProfilActionDAO.GetById(id);
        }

        public ProfilAction Update(int id, ProfilAction ProfilAction)
        {
            if (id != ProfilAction.Id)
                throw new Exception("Not valid Id");
            else
                return ProfilActionDAO.Update(ProfilAction);
        }

        public void Delete(int id)
        {
            ProfilActionDAO.Delete(id);
        }

        public IEnumerable<ProfilAction> Get()
        {
            return ProfilActionDAO.Get();
        }


        public ProfilAction Create(ProfilAction ProfilAction)
        {
            return ProfilActionDAO.Create(ProfilAction);
        }


    }
}
