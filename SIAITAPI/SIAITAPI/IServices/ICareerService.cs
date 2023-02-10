using SIAITAPI.Models;

namespace SIAITAPI.IServices
{
    public interface ICareerService
    {
        public IEnumerable<Career> Get();

        public Career GetById(int id);

        public Career Update(int id, Career career);

        public Career Create(Career career);
        public void Delete(int id);
    }
}
