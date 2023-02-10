using SIAITAPI.IDAO;
using SIAITAPI.IServices;
using SIAITAPI.Models;

namespace SIAITAPI.Services
{
    public class CivilStatusService : ICivilStatusService
    {
        private ICivilStatusDAO CivilStatusDAO;
        public CivilStatusService(ICivilStatusDAO civilStatusDAO)
        {
            CivilStatusDAO = civilStatusDAO;
        }

        public CivilStatus GetById(int id)
        {
            return CivilStatusDAO.GetById(id);
        }

        public CivilStatus Update(int id, CivilStatus CivilStatus)
        {
            if (id != CivilStatus.Id)
                throw new Exception("Not valid Id");
            else
                return CivilStatusDAO.Update(CivilStatus);
        }

        public void Delete(int id)
        {
            CivilStatusDAO.Delete(id);
        }

        public IEnumerable<CivilStatus> Get()
        {
            return CivilStatusDAO.Get();
        }


        public CivilStatus Create(CivilStatus CivilStatus)
        {
            return CivilStatusDAO.Create(CivilStatus);
        }
    }
}
