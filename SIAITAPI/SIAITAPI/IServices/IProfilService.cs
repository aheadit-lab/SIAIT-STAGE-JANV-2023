using SIAITAPI.Models;

namespace SIAITAPI.IServices
{
    public interface IProfilService
    {
        public IEnumerable<Profil> Get();

        public Profil GetById(int id);

        public Profil Update(int id, Profil profil);

        public Profil Create(Profil profil);
        public void Delete(int id);
    }
}
