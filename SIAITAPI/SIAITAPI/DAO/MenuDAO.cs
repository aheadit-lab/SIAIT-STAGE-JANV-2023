using SIAITAPI.Data;
using SIAITAPI.IDAO;
using SIAITAPI.Models;

namespace SIAITAPI.DAO
{
    public class MenuDAO : IMenuDAO
    {
        private ModelDbContext Context;
        public MenuDAO(ModelDbContext context)
        {
            this.Context = context;
        }

        public IEnumerable<Menu> Get()
        {
            return this.Context.Menu.ToList();


        }

        public Menu Create(Menu menu)
        {
            menu.CreatedAt = DateTime.Now;
            menu.UpdatedAt = DateTime.Now;
            this.Context.Menu.Add(menu);
            this.Context.SaveChanges();
            return menu;
        }

        public Menu GetById(int id)
        {
            IQueryable<Menu> categories = this.Context.Menu.Where(c => c.Id == id);
            return categories.SingleOrDefault();
        }

        public Menu Update(Menu menu)
        {
            menu.UpdatedAt = DateTime.Now;
            this.Context.Menu.Update(menu);
            this.Context.SaveChanges();
            return menu;
        }

        public void Delete(int id)
        {
            Menu toDelete = this.Context.Menu.Where(x => x.Id == id).SingleOrDefault();
            if (toDelete == null)
                return;
            this.Context.Menu.Remove(toDelete);
            this.Context.SaveChanges();
        }

    }
}
