using SIAITAPI.Models;

namespace SIAITAPI.IDAO
{
    public interface IProfilActionDAO
    {
        public IEnumerable<ProfilAction> Get();


        public ProfilAction Create(ProfilAction profilAction);


        public ProfilAction GetById(int id);


        public ProfilAction Update(ProfilAction profilAction);


        public void Delete(int id);
    }
}
