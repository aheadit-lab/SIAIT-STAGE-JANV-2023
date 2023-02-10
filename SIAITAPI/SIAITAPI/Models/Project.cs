using SIAITAPI.DTO;
using System.ComponentModel.DataAnnotations;

namespace SIAITAPI.Models
{
    public class Project
    {

        public Project(ProjectDTO projectDTO)
        {
            Id = projectDTO.Id;
            this.Name = projectDTO.Name;
            this.NumberOfDays = projectDTO.NumberOfDays;
            if (projectDTO.Manager != null)
            { this.Manager = new Collaborator(projectDTO.Manager); }
            this.ManagerId = projectDTO.ManagerId;
            this.StartDate = projectDTO.StartDate;
            this.EndDate = projectDTO.EndDate;
            this.CreatedAt = projectDTO.CreatedAt;
            this.UpdatedAt = projectDTO.UpdatedAt;
            this.Active = projectDTO.Active;
            this.ConsumedDays = projectDTO.ConsumedDays;
            this.IsExtern = projectDTO.IsExtern;


        }


        public Project()
        {
        }

        public int Id { get; set; }
         [Required]
        public string? Name { get; set; }
        public float? NumberOfDays { get; set; }
        public float? ConsumedDays { get; set; } = 0;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Active { get; set; }
        public bool? IsExtern { get; set; }
        public virtual Collaborator? Manager { get; set; }
        public int? ManagerId { get; set; }


    }
}
