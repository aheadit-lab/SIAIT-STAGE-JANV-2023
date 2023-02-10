using SIAITAPI.IDAO;
using SIAITAPI.IServices;
using SIAITAPI.Models;

namespace SIAITAPI.Services
{
    public class CareerService : ICareerService
    {
        private ICareerDAO CareerDAO;
        public CareerService(ICareerDAO careerDAO)
        {
            CareerDAO = careerDAO;
        }

        public Career GetById(int id)
        {
            return CareerDAO.GetById(id);
        }

        public Career Update(int id, Career Career)
        {
            if (id != Career.Id)
                throw new Exception("Not valid Id");
            else
                return CareerDAO.Update(Career);
        }

        public void Delete(int id)
        {
            CareerDAO.Delete(id);
        }

        public IEnumerable<Career> Get()
        {
            return CareerDAO.Get();
        }


        public Career Create(Career Career)
        {
            return CareerDAO.Create(Career);
        }
    }
}
