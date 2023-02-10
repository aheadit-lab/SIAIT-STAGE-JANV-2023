using SIAITAPI.Models;

namespace SIAITAPI.DTO
{
    public class ProfilMenuDTO
    {
        public ProfilMenuDTO(ProfilMenu profilMenu)
        {
            this.Id = profilMenu.Id;
            this.ProfilId = profilMenu.ProfilId;
            this.MenuId = profilMenu.MenuId;

            if (profilMenu.Menu != null)
            { this.Menu = new MenuDTO(profilMenu.Menu); }


            if (profilMenu.Profil != null)
            { this.Profil = new ProfilDTO(profilMenu.Profil); }


            this.CreatedAt = profilMenu.CreatedAt;
            this.UpdatedAt = profilMenu.UpdatedAt;
        }

        public ProfilMenuDTO()
        {
        }


        public int Id { get; set; }

       
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public virtual ProfilDTO? Profil { get; set; }
        public int? ProfilId { get; set; }
        public virtual MenuDTO? Menu { get; set; }
        public int? MenuId { get; set; }
    }
}
