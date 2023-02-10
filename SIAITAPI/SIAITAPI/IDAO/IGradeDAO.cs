using SIAITAPI.Models;

namespace SIAITAPI.IDAO
{
    public interface IGradeDAO
    {
        public IEnumerable<Grade> Get();


        public Grade Create(Grade grade);


        public Grade GetById(int id);


        public Grade Update(Grade grade);


        public void Delete(int id);
    }
}
