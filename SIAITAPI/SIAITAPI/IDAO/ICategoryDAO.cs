using SIAITAPI.Models;

namespace SIAITAPI.IDAO
{
    public interface ICategoryDAO
    {
        public IEnumerable<Category> Get();


        public Category Create(Category category);


        public Category GetById(int id);


        public Category Update(Category category);


        public void Delete(int id);
       
    }
}
