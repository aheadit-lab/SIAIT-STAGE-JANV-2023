using SIAITAPI.DTO;
using System.ComponentModel.DataAnnotations;

namespace SIAITAPI.Models
{
    public class Profil
    {
        public Profil()

        {
            ProfilAction = new HashSet<ProfilAction>();
            Collaborator = new HashSet<Collaborator>();
            ProfilMenu = new HashSet<ProfilMenu>();

        }
        public Profil(ProfilDTO profilDTO) 
        {
            this.Id = profilDTO.Id;
            this.Name = profilDTO.Name;
            this.Code = profilDTO.Code;
            this.CreatedAt = profilDTO.CreatedAt;
            this.UpdatedAt = profilDTO.UpdatedAt;
        }

        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Code { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public virtual ICollection<ProfilAction> ProfilAction { get; set; }
        public virtual ICollection<ProfilMenu> ProfilMenu { get; set; }
        public virtual ICollection<Collaborator> Collaborator { get; set; }


    }
}
