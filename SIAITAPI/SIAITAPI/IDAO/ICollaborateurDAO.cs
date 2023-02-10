using SIAITAPI.Models;

namespace SIAITAPI.IDAO
{
    public interface ICollaborateurDAO
    {
        public IEnumerable<Collaborator> Get();


        public Collaborator Create(Collaborator collaborator);


        public Collaborator GetById(int id);


        public Collaborator Update(Collaborator collaborator);

       public Collaborator Login(string username, string password);
        public void Delete(int id);
    }
}
