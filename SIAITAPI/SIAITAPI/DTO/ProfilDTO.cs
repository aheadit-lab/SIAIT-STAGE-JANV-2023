using SIAITAPI.Models;

namespace SIAITAPI.DTO
{
    public class ProfilDTO
    {
            public ProfilDTO(Profil profil) 
            {
                this.Id = profil.Id;
                this.Name = profil.Name;
                this.Code = profil.Code;
                this.CreatedAt = profil.CreatedAt;
                this.UpdatedAt = profil.UpdatedAt;
            }

            public ProfilDTO()
            {
                
            }

            public string? Code { get; set; }

            public DateTime? CreatedAt { get; set; }

            public int Id { get; set; }

            public string? Name { get; set; }

            public DateTime? UpdatedAt { get; set; }
        }
}
