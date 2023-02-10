using SIAITAPI.Data;
using SIAITAPI.IDAO;
using SIAITAPI.Models;

namespace SIAITAPI.DAO
{
    public class CareerDAO : ICareerDAO
    {
        private ModelDbContext Context;
        public CareerDAO(ModelDbContext context)
        {
            this.Context = context;
        }

        public IEnumerable<Career> Get()
        {
            return this.Context.Career.ToList();


        }

        public Career Create(Career career)
        {
            career.CreatedAt = DateTime.Now;
            career.UpdatedAt = DateTime.Now;

            var existingCareers = this.Context.Career.ToList().Where(a=>a.CollaboratorId==career.CollaboratorId);

            
            foreach (var existingCareer in existingCareers)
            {
                if ((existingCareer.From <= career.To && existingCareer.To >= career.From ) || (career.To<career.From) ||
              (existingCareer.To>=career.From && existingCareer.From<=career.To) || (existingCareer.From<=career.From && existingCareer.To>=career.To)
              || (existingCareer.From>=career.From && existingCareer.To<=career.To))
                {
                    throw new Exception("The 'from' and 'to' fields overlap with an existing career or invalid dates");
                }
              

            }

            this.Context.Career.Add(career);
            this.Context.SaveChanges();
            return career;
        }

        public Career GetById(int id)
        {
            IQueryable<Career> categories = this.Context.Career.Where(c => c.Id == id);
            return categories.SingleOrDefault();
        }

        public Career Update(Career career)
        {
            career.UpdatedAt = DateTime.Now;
            var existingEntity = Context.Career.Find(career.Id);
            if (existingEntity != null)
            {
                Context.Entry(existingEntity).CurrentValues.SetValues(career);
                this.Context.Career.Update(existingEntity);
                this.Context.SaveChanges();
            }
           
            return career;
        }

        public void Delete(int id)
        {
            Career toDelete = this.Context.Career.Where(x => x.Id == id).SingleOrDefault();
            if (toDelete == null)
                return;
            this.Context.Career.Remove(toDelete);
            this.Context.SaveChanges();
        }

    }
}
