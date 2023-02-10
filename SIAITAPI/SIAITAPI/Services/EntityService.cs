using SIAITAPI.DAO;
using SIAITAPI.IDAO;
using SIAITAPI.IServices;
using SIAITAPI.Models;

namespace SIAITAPI.Services
{
    public class EntityService : IEntityService
    {
        private IEntityDAO EntityDAO;
        public EntityService(IEntityDAO entityDAO)
        {
            EntityDAO = entityDAO;
        }

        public Entity GetById(int id)
        {
            return EntityDAO.GetById(id);
        }

        public Entity Update(int id, Entity Entity)
        {
            if (id != Entity.Id)
                throw new Exception("Not valid Id");
            else
                return EntityDAO.Update(Entity);
        }

        public void Delete(int id)
        {
            EntityDAO.Delete(id);
        }

        public IEnumerable<Entity> Get()
        {
            return EntityDAO.Get();
        }


        public Entity Create(Entity Entity)
        {
            return EntityDAO.Create(Entity);
        }


    }
}
