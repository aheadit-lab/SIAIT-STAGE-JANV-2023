using SIAITAPI.DTO;
using System.ComponentModel.DataAnnotations;

namespace SIAITAPI.Models
{
    public class ProfilAction
    {

        public ProfilAction(ProfilActionDTO profilActionDTO)
        {
            this.Id = profilActionDTO.Id;
            this.ProfilId = profilActionDTO.ProfilId;
            this.ActionId = profilActionDTO.ActionId;
            this.Options = profilActionDTO.Options;
            this.CreatedAt = profilActionDTO.CreatedAt;
            this.UpdatedAt = profilActionDTO.UpdatedAt;
            if (profilActionDTO.Profil != null)
            { Profil = new Profil(profilActionDTO.Profil); }
            if (profilActionDTO.Action != null)
            { Action = new Action(profilActionDTO.Action); }
        }
        public ProfilAction() { }
        public int Id { get; set; }
      [Required]
       
        public string? Options { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public virtual Action? Action { get; set; }
        public int? ActionId { get; set; }
        public virtual Profil? Profil { get; set; }
        public int? ProfilId { get; set; }

    }
}
