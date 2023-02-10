using Microsoft.EntityFrameworkCore;
using SIAITAPI.Data;
using SIAITAPI.IDAO;
using SIAITAPI.Models;

namespace SIAITAPI.DAO
{
    public class CategoryDAO : ICategoryDAO
    {
        private ModelDbContext Context;
        public CategoryDAO(ModelDbContext context)
        {
            this.Context = context;
        }

        public IEnumerable<Category> Get()
        {
            return this.Context.Category.ToList();

              
        }

        public Category Create(Category category)
        {
            category.CreatedAt = DateTime.Now;
            category.UpdatedAt = DateTime.Now;
            this.Context.Category.Add(category);
            this.Context.SaveChanges();
            return category;
        }

        public Category GetById(int id)
        {
            IQueryable <Category> categories = this.Context.Category.Where(c=>c.Id==id);
            return categories.SingleOrDefault();
        }

        public Category Update(Category category)
        {
            category.UpdatedAt = DateTime.Now;
            this.Context.Category.Update(category);
            this.Context.SaveChanges();
            return category;
        }

        public void Delete(int id)
        {
            Category toDelete = this.Context.Category.Where(x => x.Id == id).SingleOrDefault();
            if (toDelete == null)
                return;
            this.Context.Category.Remove(toDelete);
            this.Context.SaveChanges();
        }


    }
}
