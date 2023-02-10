using SIAITAPI.Models;
namespace SIAITAPI.IServices
{
    public interface IProjetService
    {

        public IEnumerable<Project> Get();

        public Project GetById(int id);

        public Project Update(int id, Project project);

        public Project Create(Project project);
        public void Delete(int id);
    }
}
