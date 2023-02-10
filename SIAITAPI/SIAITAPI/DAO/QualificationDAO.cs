using SIAITAPI.Data;
using SIAITAPI.IDAO;
using SIAITAPI.Models;

namespace SIAITAPI.DAO
{
    public class QualificationDAO : IQualificationDAO
    {
        private ModelDbContext Context;
        public QualificationDAO(ModelDbContext context)
        {
            this.Context = context;
        }

        public IEnumerable<Qualification> Get()
        {
            return this.Context.Qualification.ToList();


        }

        public Qualification Create(Qualification Qualification)
        {
            Qualification.CreatedAt = DateTime.Now;
            Qualification.UpdatedAt = DateTime.Now;
            this.Context.Qualification.Add(Qualification);
            this.Context.SaveChanges();
            return Qualification;
        }

        public Qualification GetById(int id)
        {
            IQueryable<Qualification> categories = this.Context.Qualification.Where(c => c.Id == id);
            return categories.SingleOrDefault();
        }

        public Qualification Update(Qualification Qualification)
        {
            Qualification.UpdatedAt = DateTime.Now;
            this.Context.Qualification.Update(Qualification);
            this.Context.SaveChanges();
            return Qualification;
        }

        public void Delete(int id)
        {
            Qualification toDelete = this.Context.Qualification.Where(x => x.Id == id).SingleOrDefault();
            if (toDelete == null)
                return;
            this.Context.Qualification.Remove(toDelete);
            this.Context.SaveChanges();
        }
    }
}
