using SIAITAPI.Models;

namespace SIAITAPI.DTO
{
    public class ProjectDTO
    {
        public ProjectDTO(Project project)
        {
                 Id = project.Id;
            this.Name = project.Name;
            this.NumberOfDays = project.NumberOfDays;
            if (project.Manager != null)
            { this.Manager = new CollaboratorDTO(project.Manager); }
            this.ManagerId = project.ManagerId;
            this.StartDate = project.StartDate;
            this.EndDate = project.EndDate;
            this.CreatedAt = project.CreatedAt;
            this.UpdatedAt = project.UpdatedAt;
            this.Active = project.Active;
            this.ConsumedDays = project.ConsumedDays;
            this.IsExtern = project.IsExtern;

           
            }
        

        public ProjectDTO()
        {
        }

        public int Id { get; set; }
        
        public string? Name { get; set; }
        public float? NumberOfDays { get; set; }
        public float? ConsumedDays { get; set; } = 0;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Active { get; set; }
        public bool? IsExtern { get; set; }
        public virtual CollaboratorDTO? Manager { get; set; }
        public int? ManagerId { get; set; }


    }
}
