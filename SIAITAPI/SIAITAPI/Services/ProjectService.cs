using SIAITAPI.DAO;
using SIAITAPI.IDAO;
using SIAITAPI.IServices;
using SIAITAPI.Models;

namespace SIAITAPI.Services
{
    public class ProjectService : IProjetService
    {
        private IProjectDAO ProjectDAO;
        public ProjectService(IProjectDAO projectDAO)
        {
            ProjectDAO = projectDAO;
        }

        public Project GetById(int id)
        {
            return ProjectDAO.GetById(id);
        }

        public Project Update(int id, Project Project)
        {
            if (id != Project.Id)
                throw new Exception("Not valid Id");
            else
                return ProjectDAO.Update(Project);
        }

        public void Delete(int id)
        {
            ProjectDAO.Delete(id);
        }

        public IEnumerable<Project> Get()
        {
            return ProjectDAO.Get();
        }


        public Project Create(Project Project)
        {
            return ProjectDAO.Create(Project);
        }


    }
}
