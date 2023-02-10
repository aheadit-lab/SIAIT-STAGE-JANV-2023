using SIAITAPI.DTO;
using System.ComponentModel.DataAnnotations;

namespace SIAITAPI.Models
{
    public class Menu
    {
        public Menu()
        {
            Action = new HashSet<Action>();
            ProfilMenu = new HashSet<ProfilMenu>();

        }
        public Menu(MenuDTO menuDto)
        {
            this.Id = menuDto.Id;
            this.Title = menuDto.Title;
            this.Path = menuDto.Path;
            this.Icon = menuDto.Icon;
            this.OnlySuperUser = menuDto.OnlySuperUser;
            this.Order = menuDto.Order;
            this.ModuleId = menuDto.ModuleId;
            if (menuDto.Module != null)
            { this.Module = new Module(menuDto.Module); }
            this.CreatedAt = menuDto.CreatedAt;
            this.UpdatedAt = menuDto.UpdatedAt;
            this.Class = menuDto.Class;
        }
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? Path { get; set; }
        public string? Icon { get; set; }
        public string? Class { get; set; }
        public bool? OnlySuperUser { get; set; }
        public int? Order { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Module? Module { get; set; }
        public int? ModuleId { get; set; }
        public virtual ICollection<Action> Action { get; set; }
        public virtual ICollection<ProfilMenu> ProfilMenu { get; set; }
    }
}
