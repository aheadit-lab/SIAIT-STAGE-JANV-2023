using SIAITAPI.DTO;
using System.ComponentModel.DataAnnotations;

namespace SIAITAPI.Models
{
    public class Entity
    {
        public Entity(EntityDTO entityDTO)
        {
            this.Id = entityDTO.Id;
            this.Name = entityDTO.Name;
            this.TaxRegistrationNumber = entityDTO.TaxRegistrationNumber;
            this.TradeRegister = entityDTO.TradeRegister;
            this.ExploitationCode = entityDTO.ExploitationCode;
            this.Address = entityDTO.Address;
            this.EmployerCode = entityDTO.EmployerCode;
            this.SocialSecurityScheme = entityDTO.SocialSecurityScheme;
            this.RNE = entityDTO.RNE;
            this.Email = entityDTO.Email;
            this.Telephone = entityDTO.Telephone;
            this.CreationDate = entityDTO.CreationDate;
            this.CreatedAt = entityDTO.CreatedAt;
            this.UpdatedAt = entityDTO.UpdatedAt;
        }

        public Entity()
        {
        }
        public int Id { get; set; }
       [Required]
        public string? Name { get; set; }
        public string? TaxRegistrationNumber { get; set; }
        public string? TradeRegister { get; set; }
        public string? ExploitationCode { get; set; }
        public string? Address { get; set; }
        public string? EmployerCode { get; set; }
        public string? SocialSecurityScheme { get; set; }
        public string? RNE { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? Email { get; set; }
        public string? Telephone { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    
}
}
