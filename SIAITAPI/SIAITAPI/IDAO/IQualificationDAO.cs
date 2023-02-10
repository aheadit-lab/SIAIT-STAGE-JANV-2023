using SIAITAPI.Models;

namespace SIAITAPI.IDAO
{
    public interface IQualificationDAO
    {
        public IEnumerable<Qualification> Get();


        public Qualification Create(Qualification qualification);


        public Qualification GetById(int id);


        public Qualification Update(Qualification qualification);


        public void Delete(int id);
    }
}
