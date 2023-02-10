using SIAITAPI.Models;

namespace SIAITAPI.IServices
{
    public interface ICivilStatusService
    {
        public IEnumerable<CivilStatus> Get();

        public CivilStatus GetById(int id);

        public CivilStatus Update(int id, CivilStatus civilStatus);

        public CivilStatus Create(CivilStatus civilStatus);
        public void Delete(int id);
    }
}
