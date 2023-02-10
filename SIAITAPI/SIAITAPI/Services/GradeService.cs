using SIAITAPI.DAO;
using SIAITAPI.IDAO;
using SIAITAPI.IServices;
using SIAITAPI.Models;

namespace SIAITAPI.Services
{
    public class GradeService : IGradeService
    {
        private IGradeDAO GradeDAO;
        public GradeService(IGradeDAO gradeDAO)
        {
            GradeDAO = gradeDAO;
        }

        public Grade GetById(int id)
        {
            return GradeDAO.GetById(id);
        }

        public Grade Update(int id, Grade Grade)
        {
            if (id != Grade.Id)
                throw new Exception("Not valid Id");
            else
                return GradeDAO.Update(Grade);
        }

        public void Delete(int id)
        {
            GradeDAO.Delete(id);
        }

        public IEnumerable<Grade> Get()
        {
            return GradeDAO.Get();
        }


        public Grade Create(Grade Grade)
        {
            return GradeDAO.Create(Grade);
        }


    }
}
