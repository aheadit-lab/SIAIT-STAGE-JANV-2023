using Action=  SIAITAPI.Models.Action;

namespace SIAITAPI.IDAO
{
    public interface IActionDAO
    {
        public IEnumerable<Action> Get();


        public Action Create(Action action);


        public Action GetById(int id);


        public Action Update(Action action);


        public void Delete(int id);
    }
}
