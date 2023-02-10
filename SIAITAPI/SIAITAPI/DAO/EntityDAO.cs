using SIAITAPI.Data;
using SIAITAPI.IDAO;
using SIAITAPI.Models;

namespace SIAITAPI.DAO
{
    public class EntityDAO : IEntityDAO
    {
        private ModelDbContext Context;
        public EntityDAO(ModelDbContext context)
        {
            this.Context = context;
        }

        public IEnumerable<Entity> Get()
        {
            return this.Context.Entity.ToList();


        }

        public Entity Create(Entity Entity)
        {
            Entity.CreatedAt = DateTime.Now;
            Entity.UpdatedAt = DateTime.Now;
            this.Context.Entity.Add(Entity);
            this.Context.SaveChanges();
            return Entity;
        }

        public Entity GetById(int id)
        {
            IQueryable<Entity> categories = this.Context.Entity.Where(c => c.Id == id);
            return categories.SingleOrDefault();
        }

        public Entity Update(Entity Entity)
        {
            Entity.UpdatedAt = DateTime.Now;
            this.Context.Entity.Update(Entity);
            this.Context.SaveChanges();
            return Entity;
        }

        public void Delete(int id)
        {
            Entity toDelete = this.Context.Entity.Where(x => x.Id == id).SingleOrDefault();
            if (toDelete == null)
                return;
            this.Context.Entity.Remove(toDelete);
            this.Context.SaveChanges();
        }
    }
}
