using SIAITAPI.Models;

namespace SIAITAPI.IServices
{
    public interface IMenuService
    {
        public IEnumerable<Menu> Get();

        public Menu GetById(int id);

        public Menu Update(int id, Menu menu);

        public Menu Create(Menu menu);
        public void Delete(int id);
    }
}
