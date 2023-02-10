using SIAITAPI.DAO;
using SIAITAPI.IDAO;
using SIAITAPI.IServices;
using SIAITAPI.Models;

namespace SIAITAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryDAO ICategoryDAO;
        public CategoryService(ICategoryDAO IcategoryDAO)
        {
            ICategoryDAO = IcategoryDAO;
        }

        public Category GetById(int id)
        {
            return ICategoryDAO.GetById(id);
        }

        public Category Update(int id,Category category)
        {
            if (id != category.Id)
                throw new Exception("Not valid Id");
            else
                return ICategoryDAO.Update(category);
        }

        public void Delete(int id)
        {
            ICategoryDAO.Delete(id);
        }

        public IEnumerable<Category> Get()
        {
            return ICategoryDAO.Get();
        }


        public Category Create(Category category)
        {
            return ICategoryDAO.Create(category);
        }


    }
}
