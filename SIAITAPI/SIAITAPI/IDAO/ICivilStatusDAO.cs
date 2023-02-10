using SIAITAPI.Models;

namespace SIAITAPI.IDAO
{
    public interface ICivilStatusDAO
    {
        public IEnumerable<CivilStatus> Get();


        public CivilStatus Create(CivilStatus civilStatus);


        public CivilStatus GetById(int id);


        public CivilStatus Update(CivilStatus civilStatus);


        public void Delete(int id);
    }
}
