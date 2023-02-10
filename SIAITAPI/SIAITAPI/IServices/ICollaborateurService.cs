using SIAITAPI.Models;
namespace SIAITAPI.IServices
{
    public interface ICollaborateurService
    {
        public IEnumerable<Collaborator> Get();

        public Collaborator GetById(int id);

        public Collaborator Update(int id, Collaborator Collaborator);

        public Collaborator Create(Collaborator Collaborator);

        public Collaborator GetUserByLoginAndPwd(string username, string password);
        public void Delete(int id);
    }
}
