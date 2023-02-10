using SIAITAPI.DTO;
using System.ComponentModel.DataAnnotations;

namespace SIAITAPI.Models
{
    public class Module
    {

        public Module(ModuleDTO moduleDTO)
        {
            this.Id = moduleDTO.Id;
            this.Title = moduleDTO.Title;
            this.Path = moduleDTO.Path;
            this.Icon = moduleDTO.Icon;
            this.Active = moduleDTO.Active;
            this.OnlySuperUser = moduleDTO.OnlySuperUser;
            this.Order = moduleDTO.Order;
            this.CreatedAt = moduleDTO.CreatedAt;
            this.UpdatedAt = moduleDTO.UpdatedAt;
            this.Class = moduleDTO.Class;
        }
        public Module()
        {
            Menu = new HashSet<Menu>();

        }
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? Path { get; set; }
        public string? Icon { get; set; }
        public string? Class { get; set; }
        public bool? Active { get; set; }
        public bool? OnlySuperUser { get; set; }
        public int? Order { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public virtual ICollection<Menu> Menu { get; set; }

    }
}
