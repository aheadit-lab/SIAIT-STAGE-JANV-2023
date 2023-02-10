using SIAITAPI.Models;

namespace SIAITAPI.IDAO
{
    public interface IProjectDAO
    {
        public IEnumerable<Project> Get();


        public Project Create(Project project);


        public Project GetById(int id);


        public Project Update(Project project);


        public void Delete(int id);
    }
}
