using SIAITAPI.DTO;
using System.ComponentModel.DataAnnotations;

namespace SIAITAPI.Models
{
    public class ProfilMenu
    {

        public ProfilMenu(ProfilMenuDTO profilMenu)
        {
            this.Id = profilMenu.Id;
            this.ProfilId = profilMenu.ProfilId;
            this.MenuId = profilMenu.MenuId;


            if (profilMenu.Menu != null)
            { this.Menu = new Menu(profilMenu.Menu); }


            if (profilMenu.Profil != null)
            { this.Profil = new Profil(profilMenu.Profil); }

            this.CreatedAt = profilMenu.CreatedAt;
            this.UpdatedAt = profilMenu.UpdatedAt;
        }

        public ProfilMenu()
        {
        }
        [Required]
        public int Id { get; set; }
        
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public virtual Profil? Profil { get; set; }
        public int? ProfilId { get; set; }
        public virtual Menu? Menu { get; set; }
        public int? MenuId { get; set; }
       

    }
}
