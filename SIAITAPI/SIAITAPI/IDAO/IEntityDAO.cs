using SIAITAPI.Models;

namespace SIAITAPI.IDAO
{
    public interface IEntityDAO
    {
         public IEnumerable<Entity> Get();


        public Entity Create(Entity entity);


        public Entity GetById(int id);


        public Entity Update(Entity entity);


        public void Delete(int id);
    }
}
