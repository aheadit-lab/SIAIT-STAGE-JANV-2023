using SIAITAPI.Models;
using Action = SIAITAPI.Models.Action;
namespace SIAITAPI.DTO
{
    public class ProfilActionDTO
    {
        public ProfilActionDTO(ProfilAction profilAction)
        {
            Id = profilAction.Id;
            Options = profilAction.Options;
            ProfilId = profilAction.ProfilId;
            ActionId = profilAction.ActionId;
            CreatedAt = profilAction.CreatedAt;
            UpdatedAt = profilAction.UpdatedAt;
            if (profilAction.Profil != null)
            { Profil = new ProfilDTO(profilAction.Profil); }
            if (profilAction.Action != null)
            { Action = new ActionDTO(profilAction.Action); }
        }

        public ProfilActionDTO() { }

        public int? ActionId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int Id { get; set; }

        public string? Options { get; set; }

        public int? ProfilId { get; set; }

        public DateTime? UpdatedAt { get; set; }
        public virtual ProfilDTO? Profil { get; set; }
        public virtual ActionDTO? Action { get; set; }
    }
}


