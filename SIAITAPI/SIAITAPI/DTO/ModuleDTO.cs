using SIAITAPI.Models;

namespace SIAITAPI.DTO
{
    public class ModuleDTO
    {
        public ModuleDTO(Module module)
        {
            this.Id = module.Id;
            this.Title = module.Title;
            this.Path = module.Path;
            this.Icon = module.Icon;
            this.Active = module.Active;
            this.OnlySuperUser = module.OnlySuperUser;
            this.Order = module.Order;
            this.CreatedAt = module.CreatedAt;
            this.UpdatedAt = module.UpdatedAt;
            this.Class = module.Class;
        }

       public ModuleDTO() { }

        public bool? Active { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string Icon { get; set; }

        public int Id { get; set; }


        public bool? OnlySuperUser { get; set; }

        public int? Order { get; set; }

        public string Path { get; set; }

        public string Title { get; set; }
    public string? Class { get; set; }
    public DateTime? UpdatedAt { get; set; }
    
    }
}
