using SIAITAPI.DTO;
using System.ComponentModel.DataAnnotations;

namespace SIAITAPI.Models
{
    public class Qualification
    {

        public Qualification(QualificationDTO qualificationDTO)
        {
            this.Id = qualificationDTO.Id;
            this.Name = qualificationDTO.Name;
            this.Code = qualificationDTO.Code;
            this.CreatedAt = qualificationDTO.CreatedAt;
            this.UpdatedAt = qualificationDTO.UpdatedAt;
        }

        public Qualification()
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
