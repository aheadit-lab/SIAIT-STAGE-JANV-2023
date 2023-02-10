using SIAITAPI.Data;
using SIAITAPI.IDAO;
using SIAITAPI.Models;

namespace SIAITAPI.DAO
{
    public class ProjectDAO : IProjectDAO
    {
        private ModelDbContext Context;
        public ProjectDAO(ModelDbContext context)
        {
            this.Context = context;
        }

        public IEnumerable<Project> Get()
        {
            return this.Context.Project.ToList();


        }

        public Project Create(Project Project)
        {
            Project.CreatedAt = DateTime.Now;
            Project.UpdatedAt = DateTime.Now;
            this.Context.Project.Add(Project);
            this.Context.SaveChanges();
            return Project;
        }

        public Project GetById(int id)
        {
            IQueryable<Project> categories = this.Context.Project.Where(c => c.Id == id);
            return categories.SingleOrDefault();
        }

        public Project Update(Project Project)
        {
            Project.UpdatedAt = DateTime.Now;
            this.Context.Project.Update(Project);
            this.Context.SaveChanges();
            return Project;
        }

        public void Delete(int id)
        {
            Project toDelete = this.Context.Project.Where(x => x.Id == id).SingleOrDefault();
            if (toDelete == null)
                return;
            this.Context.Project.Remove(toDelete);
            this.Context.SaveChanges();
        }
    }
}
