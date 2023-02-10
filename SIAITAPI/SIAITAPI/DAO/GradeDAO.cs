using SIAITAPI.Data;
using SIAITAPI.IDAO;
using SIAITAPI.Models;

namespace SIAITAPI.DAO
{
    public class GradeDAO : IGradeDAO
    {
        private ModelDbContext Context;
        public GradeDAO(ModelDbContext context)
        {
            this.Context = context;
        }

        public IEnumerable<Grade> Get()
        {
            return this.Context.Grade.ToList();


        }

        public Grade Create(Grade grade)
        {
            grade.CreatedAt = DateTime.Now;
            grade.UpdatedAt = DateTime.Now;
            this.Context.Grade.Add(grade);
            this.Context.SaveChanges();
            return grade;
        }

        public Grade GetById(int id)
        {
            IQueryable<Grade> categories = this.Context.Grade.Where(c => c.Id == id);
            return categories.SingleOrDefault();
        }

        public Grade Update(Grade grade)
        {
            grade.UpdatedAt = DateTime.Now;
            this.Context.Grade.Update(grade);
            this.Context.SaveChanges();
            return grade;
        }

        public void Delete(int id)
        {
            Grade toDelete = this.Context.Grade.Where(x => x.Id == id).SingleOrDefault();
            if (toDelete == null)
                return;
            this.Context.Grade.Remove(toDelete);
            this.Context.SaveChanges();
        }


    }
}
