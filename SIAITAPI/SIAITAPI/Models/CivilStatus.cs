using SIAITAPI.DTO;
using System.ComponentModel.DataAnnotations;

namespace SIAITAPI.Models
{
    public class CivilStatus
    {

        public CivilStatus(CivilStatusDTO civilStatusDTO)
        {
            this.Id = civilStatusDTO.Id;
            this.Name = civilStatusDTO.Name;
            this.Code = civilStatusDTO.Code;
            this.CreatedAt = civilStatusDTO.CreatedAt;
            this.UpdatedAt = civilStatusDTO.UpdatedAt;
        }

      
        public CivilStatus()
        {
            Career = new HashSet<Career>();
            Collaborator = new HashSet<Collaborator>();

        }
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Code { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public virtual ICollection<Career> Career { get; set; }
        public virtual ICollection<Collaborator> Collaborator { get; set; }

    }
}
