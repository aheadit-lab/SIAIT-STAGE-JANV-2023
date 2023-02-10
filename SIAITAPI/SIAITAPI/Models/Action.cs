using SIAITAPI.DTO;
using System.ComponentModel.DataAnnotations;

namespace SIAITAPI.Models
{
    public class Action
    {
        public Action()
        {

           ProfilAction = new HashSet<ProfilAction>();
        }

        public Action(ActionDTO actionDTO)
        {
            Id = actionDTO.Id;
            Name = actionDTO.Name;
            Code = actionDTO.Code;
            Urls = actionDTO.Urls;
            Mandatory = actionDTO.Mandatory;
            Options = actionDTO.Options;
            OnlySuperUser = actionDTO.OnlySuperUser;
            CreatedAt = actionDTO.CreatedAt;
            UpdatedAt = actionDTO.UpdatedAt;
            MenuId = actionDTO.MenuId;
            if (actionDTO.Menu != null)
            { Menu = new Menu(actionDTO.Menu); }

        }

        
         public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Urls { get; set; }
        public bool? Mandatory { get; set; }
        public string? Options { get; set; }
        public bool? OnlySuperUser { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public virtual Menu? Menu { get; set; }
        public int? MenuId { get; set; }
        public virtual ICollection<ProfilAction> ProfilAction { get; set; }
    }
}
