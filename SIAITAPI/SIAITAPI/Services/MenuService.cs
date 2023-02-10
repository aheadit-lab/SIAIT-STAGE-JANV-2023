using SIAITAPI.DAO;
using SIAITAPI.IDAO;
using SIAITAPI.IServices;
using SIAITAPI.Models;

namespace SIAITAPI.Services
{
    public class MenuService : IMenuService
    {
        private IMenuDAO MenuDAO;
        public MenuService(IMenuDAO menuDAO)
        {
            MenuDAO = menuDAO;
        }

        public Menu GetById(int id)
        {
            return MenuDAO.GetById(id);
        }

        public Menu Update(int id, Menu Menu)
        {
            if (id != Menu.Id)
                throw new Exception("Not valid Id");
            else
                return MenuDAO.Update(Menu);
        }

        public void Delete(int id)
        {
            MenuDAO.Delete(id);
        }

        public IEnumerable<Menu> Get()
        {
            return MenuDAO.Get();
        }


        public Menu Create(Menu Menu)
        {
            return MenuDAO.Create(Menu);
        }


    }
}
