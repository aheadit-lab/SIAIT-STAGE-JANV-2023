using SIAITAPI.DAO;
using SIAITAPI.IDAO;
using SIAITAPI.IServices;
using SIAITAPI.Models;

namespace SIAITAPI.Services
{
    public class QualificationService : IQualificationService
    {
        private IQualificationDAO QualificationDAO;
        public QualificationService(IQualificationDAO qualificationDAO)
        {
            QualificationDAO = qualificationDAO;
        }

        public Qualification GetById(int id)
        {
            return QualificationDAO.GetById(id);
        }

        public Qualification Update(int id, Qualification Qualification)
        {
            if (id != Qualification.Id)
                throw new Exception("Not valid Id");
            else
                return QualificationDAO.Update(Qualification);
        }

        public void Delete(int id)
        {
            QualificationDAO.Delete(id);
        }

        public IEnumerable<Qualification> Get()
        {
            return QualificationDAO.Get();
        }


        public Qualification Create(Qualification Qualification)
        {
            return QualificationDAO.Create(Qualification);
        }


    }
}
