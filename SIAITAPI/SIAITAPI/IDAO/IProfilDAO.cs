using SIAITAPI.Models;

namespace SIAITAPI.IDAO
{
    public interface IProfilDAO
    {
        public IEnumerable<Profil> Get();


        public Profil Create(Profil profil);


        public Profil GetById(int id);


        public Profil Update(Profil profil);


        public void Delete(int id);
    }
}
