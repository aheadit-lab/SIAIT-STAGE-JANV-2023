using SIAITAPI.Data;
using SIAITAPI.IDAO;
using SIAITAPI.Models;

namespace SIAITAPI.DAO
{
    public class CivilStatusDAO : ICivilStatusDAO
    {
        private ModelDbContext Context;
        public CivilStatusDAO(ModelDbContext context)
        {
            this.Context = context;
        }

        public IEnumerable<CivilStatus> Get()
        {
            return this.Context.Civil_Status.ToList();


        }

        public CivilStatus Create(CivilStatus CivilStatus)
        {
            CivilStatus.CreatedAt = DateTime.Now;
            CivilStatus.UpdatedAt = DateTime.Now;
            this.Context.Civil_Status.Add(CivilStatus);
            this.Context.SaveChanges();
            return CivilStatus;
        }

        public CivilStatus GetById(int id)
        {
            IQueryable<CivilStatus> categories = this.Context.Civil_Status.Where(c => c.Id == id);
            return categories.SingleOrDefault();
        }

        public CivilStatus Update(CivilStatus CivilStatus)
        {
            CivilStatus.UpdatedAt = DateTime.Now;
            this.Context.Civil_Status.Update(CivilStatus);
            this.Context.SaveChanges();
            return CivilStatus;
        }

        public void Delete(int id)
        {
            CivilStatus toDelete = this.Context.Civil_Status.Where(x => x.Id == id).SingleOrDefault();
            if (toDelete == null)
                return;
            this.Context.Civil_Status.Remove(toDelete);
            this.Context.SaveChanges();
        }
    }
}
