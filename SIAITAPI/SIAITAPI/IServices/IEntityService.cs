using SIAITAPI.Models;

namespace SIAITAPI.IServices
{
    public interface IEntityService
    {
        public IEnumerable<Entity> Get();

        public Entity GetById(int id);

        public Entity Update(int id, Entity entity);

        public Entity Create(Entity entity);
        public void Delete(int id);
    }
}
