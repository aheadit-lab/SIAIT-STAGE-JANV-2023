using SIAITAPI.IDAO;
using SIAITAPI.IServices;
using Action = SIAITAPI.Models.Action;
namespace SIAITAPI.Services
{
    public class ActionService : IActionService
    {
        private IActionDAO ActionDAO;
        public ActionService(IActionDAO actionDAO)
        {
            ActionDAO = actionDAO;
        }

        public Action GetById(int id)
        {
            return ActionDAO.GetById(id);
        }

        public Action Update(int id, Action action)
        {
            if (id != action.Id)
                throw new Exception("Not valid Id");
            else
                return ActionDAO.Update(action);
        }

        public void Delete(int id)
        {
            ActionDAO.Delete(id);
        }

        public IEnumerable<Action> Get()
        {
            return ActionDAO.Get();
        }


        public Action Create(Action Action)
        {
            return ActionDAO.Create(Action);
        }
    }
}
