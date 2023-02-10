using SIAITAPI.Models;

namespace SIAITAPI.IDAO
{
    public interface IMenuDAO
    {
        public IEnumerable<Menu> Get();


        public Menu Create(Menu menu);


        public Menu GetById(int id);


        public Menu Update(Menu menu);


        public void Delete(int id);
    }
}
