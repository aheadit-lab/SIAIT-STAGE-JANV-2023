using SIAITAPI.Data;
using SIAITAPI.IDAO;
using Action = SIAITAPI.Models.Action;
namespace SIAITAPI.DAO
{
    public class ActionDAO : IActionDAO
    {
        private ModelDbContext Context;
        public ActionDAO(ModelDbContext context)
        {
            this.Context = context;
        }

        public IEnumerable<Action> Get()
        {
            return this.Context.Action.ToList();


        }

        public Action Create(Action action)
        {
            action.CreatedAt = DateTime.Now;
            action.UpdatedAt = DateTime.Now;
            this.Context.Action.Add(action);
            this.Context.SaveChanges();
            return action;
        }

        public Action GetById(int id)
        {
            IQueryable<Action> actions = this.Context.Action.Where(c => c.Id == id);
            return actions.SingleOrDefault();
        }

        public Action Update(Action action)
        {
            action.UpdatedAt = DateTime.Now;
            this.Context.Action.Update(action);
            this.Context.SaveChanges();
            return action;
        }

        public void Delete(int id)
        {
            Action toDelete = this.Context.Action.Where(x => x.Id == id).SingleOrDefault();
            if (toDelete == null)
                return;
            this.Context.Action.Remove(toDelete);
            this.Context.SaveChanges();
        }


    }
}
