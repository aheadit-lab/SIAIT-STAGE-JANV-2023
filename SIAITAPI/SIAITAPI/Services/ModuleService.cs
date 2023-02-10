using SIAITAPI.DAO;
using SIAITAPI.IDAO;
using SIAITAPI.IServices;
using SIAITAPI.Models;

namespace SIAITAPI.Services
{
    public class ModuleService : IModuleService
    {
        private IModuleDAO ModuleDAO;
        public ModuleService(IModuleDAO moduleDAO)
        {
            ModuleDAO = moduleDAO;
        }

        public Module GetById(int id)
        {
            return ModuleDAO.GetById(id);
        }

        public Module Update(int id, Module Module)
        {
            if (id != Module.Id)
                throw new Exception("Not valid Id");
            else
                return ModuleDAO.Update(Module);
        }

        public void Delete(int id)
        {
            ModuleDAO.Delete(id);
        }

        public IEnumerable<Module> Get()
        {
            return ModuleDAO.Get();
        }


        public Module Create(Module Module)
        {
            return ModuleDAO.Create(Module);
        }


    }
}
