using SIAITAPI.Models;

namespace SIAITAPI.IServices
{
    public interface IProfilMenuService
    {
        public IEnumerable<ProfilMenu> Get();

        public ProfilMenu GetById(int id);

        public ProfilMenu Update(int id, ProfilMenu profilMenu);

        public ProfilMenu Create(ProfilMenu profilMenu);
        public void Delete(int id);
    }
}
