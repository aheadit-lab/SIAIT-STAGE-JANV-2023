using SIAITAPI.Models;

namespace SIAITAPI.IServices
{
    public interface IQualificationService
    {
        public IEnumerable<Qualification> Get();

        public Qualification GetById(int id);

        public Qualification Update(int id, Qualification qualification);

        public Qualification Create(Qualification qualification);
        public void Delete(int id);
    }
}
