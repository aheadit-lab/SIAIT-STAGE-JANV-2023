using SIAITAPI.Models;

namespace SIAITAPI.IServices
{
    public interface IProfilActionService
    {
        public IEnumerable<ProfilAction> Get();

        public ProfilAction GetById(int id);

        public ProfilAction Update(int id, ProfilAction profilAction);

        public ProfilAction Create(ProfilAction profilAction);
        public void Delete(int id);
    }
}
