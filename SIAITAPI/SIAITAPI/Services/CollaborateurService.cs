using SIAITAPI.DAO;
using SIAITAPI.Models;
using SIAITAPI.IDAO;
using SIAITAPI.IServices;

namespace SIAITAPI.Services
{
   
 public class CollaborateurService : ICollaborateurService
     {
        private ICollaborateurDAO CollaborateurDAO;
        private ICareerDAO CareerDAO;
        public CollaborateurService(ICollaborateurDAO collaborateurDAO,ICareerDAO careerDAO)
        {
            CollaborateurDAO = collaborateurDAO;
            CareerDAO = careerDAO;

        }

        public Collaborator GetById(int id)
        {
            return CollaborateurDAO.GetById(id);
        }

        public Collaborator Update(int id, Collaborator Collaborateur)
        {
            if (id != Collaborateur.Id)
                throw new Exception("Not valid Id");
            else
                return CollaborateurDAO.Update(Collaborateur);
        }

        public void Delete(int id)
        {
            CollaborateurDAO.Delete(id);
        }

        public IEnumerable<Collaborator> Get()
        {
            return CollaborateurDAO.Get();
        }

        public Collaborator GetUserByLoginAndPwd(string username,string password)
        {
            return CollaborateurDAO.Login(username,password);
        }

        public Collaborator Create(Collaborator Collaborateur)
        {
            CollaborateurDAO.Create(Collaborateur);
            var career = new Career(Collaborateur);
            CareerDAO.Create(career);
            return Collaborateur;
        }
    }
}
