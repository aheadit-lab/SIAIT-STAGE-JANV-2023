using Action = SIAITAPI.Models.Action;
namespace SIAITAPI.IServices
{
    public interface IActionService
    {
        public IEnumerable<Action> Get();

        public Action GetById(int id);

        public Action Update(int id, Action Action);

        public Action Create(Action Action);
        public void Delete(int id);
    }
}
