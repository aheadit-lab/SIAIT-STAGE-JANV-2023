using SIAITAPI.Models;

namespace SIAITAPI.IDAO
{
    public interface IProfilMenuDAO
    {

        public IEnumerable<ProfilMenu> Get();


        public ProfilMenu Create(ProfilMenu profilMenu);


        public ProfilMenu GetById(int id);


        public ProfilMenu Update(ProfilMenu profilMenu);


        public void Delete(int id);
    }
}
