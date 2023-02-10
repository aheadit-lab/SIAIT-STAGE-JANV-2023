using SIAITAPI.Models;
using Action = SIAITAPI.Models.Action;

namespace SIAITAPI.DTO
    
{
    public class ActionDTO
    {
        public ActionDTO(Action action)
        {
            this.Id = action.Id;
            this.Name = action.Name;
            this.Code = action.Code;
            this.Urls = action.Urls;
            this.Mandatory = action.Mandatory;
            this.Options = action.Options;
            this.OnlySuperUser = action.OnlySuperUser;
            this.MenuId = action.MenuId;
            this.CreatedAt = action.CreatedAt;
            this.UpdatedAt = action.UpdatedAt;
            if (action.Menu != null)
            { this.Menu = new MenuDTO(action.Menu); }
        }

        public ActionDTO()
        {
        }

        public string? Code { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int Id { get; set; }

        public bool? Mandatory { get; set; }
        public virtual MenuDTO? Menu { get; set; }
       

        public int? MenuId { get; set; }

        public string? Name { get; set; }

        public bool? OnlySuperUser { get; set; }

        public string? Options { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string? Urls { get; set; }
    }

}
