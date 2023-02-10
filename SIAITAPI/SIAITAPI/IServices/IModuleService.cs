using SIAITAPI.Models;

namespace SIAITAPI.IServices
{
    public interface IModuleService
    {
        public IEnumerable<Module> Get();

        public Module GetById(int id);

        public Module Update(int id, Module Module);

        public Module Create(Module Module);
        public void Delete(int id);
    }
}
