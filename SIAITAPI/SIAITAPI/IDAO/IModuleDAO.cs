using SIAITAPI.Models;

namespace SIAITAPI.IDAO
{
    public interface IModuleDAO
    {
        public IEnumerable<Module> Get();


        public Module Create(Module module);


        public Module GetById(int id);


        public Module Update(Module module);


        public void Delete(int id);
    }
}
