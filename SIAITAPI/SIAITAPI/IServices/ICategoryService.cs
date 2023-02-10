using SIAITAPI.Models;

namespace SIAITAPI.IServices
{
    public interface ICategoryService
    {

        public IEnumerable<Category> Get();

        public Category GetById(int id);

        public Category Update(int id,Category category);

        public Category Create(Category category);
        public void Delete(int id);
    }
}
