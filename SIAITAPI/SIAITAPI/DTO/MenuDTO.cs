using SIAITAPI.Models;

namespace SIAITAPI.DTO
{
    public class MenuDTO
    {
        public MenuDTO(Menu menu)
        {
            this.Id = menu.Id;
            this.Title = menu.Title;
            this.Path = menu.Path;
            this.Icon = menu.Icon;
            this.OnlySuperUser = menu.OnlySuperUser;
            this.Order = menu.Order;
            this.ModuleId = menu.ModuleId;
            if (menu.Module != null)
            { this.Module = new ModuleDTO(menu.Module); }
            this.CreatedAt = menu.CreatedAt;
            this.UpdatedAt = menu.UpdatedAt;
            this.Class = menu.Class;
        }

        public MenuDTO()
        {

        }
       

        public DateTime? CreatedAt { get; set; }

        public string Icon { get; set; }

        public int Id { get; set; }


        public string? Class { get; set; }

        public bool? OnlySuperUser { get; set; }

        public int? Order { get; set; }

        public string Path { get; set; }

        public string Title { get; set; }
        public virtual ModuleDTO? Module { get; set; }
        public int? ModuleId { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
