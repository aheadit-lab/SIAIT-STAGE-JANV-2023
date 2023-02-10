using SIAITAPI.Models;

namespace SIAITAPI.IServices
{
    public interface IGradeService
    {
        public IEnumerable<Grade> Get();

        public Grade GetById(int id);

        public Grade Update(int id, Grade Grade);

        public Grade Create(Grade Grade);
        public void Delete(int id);
    }
}
