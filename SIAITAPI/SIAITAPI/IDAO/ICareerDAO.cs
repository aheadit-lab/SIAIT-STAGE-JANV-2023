using SIAITAPI.Models;

namespace SIAITAPI.IDAO
{
    public interface ICareerDAO
    {
        public IEnumerable<Career> Get();


        public Career Create(Career career);


        public Career GetById(int id);


        public Career Update(Career career);


        public void Delete(int id);
    }
}
