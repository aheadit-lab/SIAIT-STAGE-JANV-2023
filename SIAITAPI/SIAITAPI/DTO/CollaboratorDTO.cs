using SIAITAPI.Models;

namespace SIAITAPI.DTO
{
    public class CollaboratorDTO
    {
        public CollaboratorDTO(Collaborator collaborator)
        {
            this.Id = collaborator.Id;
            this.RegistrationNumber = collaborator.RegistrationNumber;
            this.FirstName = collaborator.FirstName;
            this.LastName = collaborator.LastName;
            this.Email = collaborator.Email;
            this.PhoneNumber = collaborator.PhoneNumber;
            this.Cin = collaborator.Cin;
            this.Cnss = collaborator.Cnss;
            this.BirthDate = collaborator.BirthDate;
            this.Sex = collaborator.Sex;
            this.HiringDate = collaborator.HiringDate;
            this.Salary = collaborator.Salary;
            this.Bban = collaborator.Bban;
            this.LeavesBalance = collaborator.LeavesBalance;
            this.NumberOfChildren = collaborator.NumberOfChildren;
            this.HouseHolder = collaborator.HouseHolder;
            this.GradeId = collaborator.GradeId;
          this.LeavesBalanceDate = collaborator.LeavesBalanceDate;
            this.CivilStatusId=collaborator.CivilStatusId;
            this.QualificationId= collaborator.QualificationId;
            this.CategoryId = collaborator.CategoryId;
            this.CreatedAt = collaborator.CreatedAt;
            this.UpdatedAt = collaborator.UpdatedAt;
            if (collaborator.Category != null)
            { this.Category = new CategoryDTO(collaborator.Category); }
            if (collaborator.Grade != null)
            { this.Grade = new GradeDTO(collaborator.Grade); }
            if (collaborator.Qualification != null)
            { this.Qualification = new QualificationDTO(collaborator.Qualification); }
            if (collaborator.CivilStatus != null)
            { this.CivilStatus = new CivilStatusDTO(collaborator.CivilStatus); }
            this.Password = collaborator.Password;
            this.UserName = collaborator.UserName;
            this.SuperUser = collaborator.SuperUser;

            if (collaborator.Profil != null)
            { this.Profil = new ProfilDTO(collaborator.Profil); }
            this.ProfilId = collaborator.ProfilId;
        }

        public CollaboratorDTO()
        {
        }
        public int Id { get; set; }
        
        public string? Bban { get; set; }

        public DateTime? BirthDate { get; set; }

        public virtual CategoryDTO? Category { get; set; }

        public int? CategoryId { get; set; }

        public string? Cin { get; set; }
        public virtual CivilStatusDTO? CivilStatus { get; set; }
        public int? CivilStatusId { get; set; }

        public string? Cnss { get; set; }

        public string? Email { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public virtual GradeDTO? Grade { get; set; }
        public int? GradeId { get; set; }

        public DateTime? HiringDate { get; set; }

        public bool? HouseHolder { get; set; }

        public float? LeavesBalance { get; set; }

        public DateTime? LeavesBalanceDate { get; set; }

        public int? NumberOfChildren { get; set; }

        public string? PhoneNumber { get; set; }

        public virtual QualificationDTO? Qualification { get; set; }

        public int? QualificationId { get; set; }
        public string? RegistrationNumber { get; set; }

        public float? Salary { get; set; }

        public string? Sex { get; set; }
        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
       
        public string? UserName { get; set; }
        public string? Password { get; set; }
        
        public bool? SuperUser { get; set; }

        
        public virtual ProfilDTO? Profil { get; set; }
        public int? ProfilId { get; set; }
        

    }
}
