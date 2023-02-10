using SIAITAPI.DTO;
using System.ComponentModel.DataAnnotations;

namespace SIAITAPI.Models
{
    public class Category
    {
        public Category(CategoryDTO categoryDTO)
        {
            this.Id = categoryDTO.Id;
            this.Name = categoryDTO.Name;
            this.Code = categoryDTO.Code;
            this.CreatedAt = categoryDTO.CreatedAt;
            this.UpdatedAt = categoryDTO.UpdatedAt;
        }

       
        public Category()
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
