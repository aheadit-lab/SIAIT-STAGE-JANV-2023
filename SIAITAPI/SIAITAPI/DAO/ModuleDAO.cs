using SIAITAPI.Data;
using SIAITAPI.IDAO;
using SIAITAPI.Models;

namespace SIAITAPI.DAO
{
    public class ModuleDAO : IModuleDAO
    {
        private ModelDbContext Context;
        public ModuleDAO(ModelDbContext context)
        {
            this.Context = context;
        }

        public IEnumerable<Module> Get()
        {
            return this.Context.Module.ToList();


        }

        public Module Create(Module Module)
        {
            Module.CreatedAt = DateTime.Now;
            Module.UpdatedAt = DateTime.Now;
            this.Context.Module.Add(Module);
            this.Context.SaveChanges();
            return Module;
        }

        public Module GetById(int id)
        {
            IQueryable<Module> categories = this.Context.Module.Where(c => c.Id == id);
            return categories.SingleOrDefault();
        }

        public Module Update(Module Module)
        {
            Module.UpdatedAt = DateTime.Now;
            this.Context.Module.Update(Module);
            this.Context.SaveChanges();
            return Module;
        }

        public void Delete(int id)
        {
            Module toDelete = this.Context.Module.Where(x => x.Id == id).SingleOrDefault();
            if (toDelete == null)
                return;
            this.Context.Module.Remove(toDelete);
            this.Context.SaveChanges();
        }
    }
}
