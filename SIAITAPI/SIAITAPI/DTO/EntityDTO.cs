using SIAITAPI.Models;

namespace SIAITAPI.DTO
{
    public class EntityDTO
    {
        public EntityDTO(Entity entity)
        {
            this.Id = entity.Id;
            this.Name = entity.Name;
            this.TaxRegistrationNumber = entity.TaxRegistrationNumber;
            this.TradeRegister = entity.TradeRegister;
            this.ExploitationCode = entity.ExploitationCode;
            this.Address = entity.Address;
            this.EmployerCode = entity.EmployerCode;
            this.SocialSecurityScheme = entity.SocialSecurityScheme;
            this.RNE = entity.RNE;
            this.Email = entity.Email;
            this.Telephone = entity.Telephone;
            this.CreationDate = entity.CreationDate;
            this.CreatedAt = entity.CreatedAt;
            this.UpdatedAt = entity.UpdatedAt;
        }

        public EntityDTO()
        {
        }

        public string Address { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? CreationDate { get; set; }

        public string Email { get; set; }

        public string EmployerCode { get; set; }

        public string ExploitationCode { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string RNE { get; set; }

        public string SocialSecurityScheme { get; set; }

        public string TaxRegistrationNumber { get; set; }

        public string Telephone { get; set; }

        public string TradeRegister { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
