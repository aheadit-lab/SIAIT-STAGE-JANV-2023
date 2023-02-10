using SIAITAPI.DTO;
using System.ComponentModel.DataAnnotations;

namespace SIAITAPI.Models
{
    public class Grade
    {

        public Grade(GradeDTO gradeDTO)
        {
            this.Id = gradeDTO.Id;
            this.Name = gradeDTO.Name;
            this.Code = gradeDTO.Code;
            this.CreatedAt = gradeDTO.CreatedAt;
            this.UpdatedAt = gradeDTO.UpdatedAt;
        }

        public Grade()
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
