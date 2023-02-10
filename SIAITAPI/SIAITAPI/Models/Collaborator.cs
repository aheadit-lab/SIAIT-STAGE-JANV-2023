using SIAITAPI.DTO;
using System.ComponentModel.DataAnnotations;

namespace SIAITAPI.Models
{
    public class Collaborator
    {

        public Collaborator(CollaboratorDTO collaboratorDTO)
        {
            this.Id = collaboratorDTO.Id;
            this.RegistrationNumber = collaboratorDTO.RegistrationNumber;
            this.FirstName = collaboratorDTO.FirstName;
            this.LastName = collaboratorDTO.LastName;
            this.Email = collaboratorDTO.Email;
            this.PhoneNumber = collaboratorDTO.PhoneNumber;
            this.Cin = collaboratorDTO.Cin;
            this.Cnss = collaboratorDTO.Cnss;
            this.BirthDate = collaboratorDTO.BirthDate;
            this.Sex = collaboratorDTO.Sex;
            this.HiringDate = collaboratorDTO.HiringDate;
            this.Salary = collaboratorDTO.Salary;
            this.Bban = collaboratorDTO.Bban;
            this.LeavesBalance = collaboratorDTO.LeavesBalance;
            this.NumberOfChildren = collaboratorDTO.NumberOfChildren;
            this.HouseHolder = collaboratorDTO.HouseHolder;
            this.GradeId = collaboratorDTO.GradeId;
            this.LeavesBalanceDate = collaboratorDTO.LeavesBalanceDate;
            this.CivilStatusId = collaboratorDTO.CivilStatusId;
            this.QualificationId = collaboratorDTO.QualificationId;
            this.CategoryId = collaboratorDTO.CategoryId;
            this.CreatedAt = collaboratorDTO.CreatedAt;
            this.UpdatedAt = collaboratorDTO.UpdatedAt;
            if (collaboratorDTO.Category!= null)
            { this.Category = new Category(collaboratorDTO.Category); }
            if (collaboratorDTO.Grade != null)
            { this.Grade = new Grade(collaboratorDTO.Grade); }
            if (collaboratorDTO.Qualification != null)
            { this.Qualification = new Qualification(collaboratorDTO.Qualification); }
            if (collaboratorDTO.CivilStatus != null)
            { this.CivilStatus = new CivilStatus(collaboratorDTO.CivilStatus); }


            this.Password = collaboratorDTO.Password;
            this.UserName= collaboratorDTO.UserName;
            this.SuperUser = collaboratorDTO.SuperUser;

            if (collaboratorDTO.Profil != null)
            { this.Profil = new Profil(collaboratorDTO.Profil); }
            this.ProfilId= collaboratorDTO.ProfilId;
    }
        public Collaborator()
        {
            Career = new HashSet<Career>();
            Project = new HashSet<Project>();

        }
        public int Id { get; set; }
        [Required]
        public string? Bban { get; set; }

        public DateTime? BirthDate { get; set; }
        public virtual ICollection<Career> Career { get; set; }

        public virtual Category? Category { get; set; }

        public int? CategoryId { get; set; }

        public string? Cin { get; set; }
        public virtual CivilStatus? CivilStatus { get; set; }
        public int? CivilStatusId { get; set; }

        public string? Cnss { get; set; }

        public string? Email { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public virtual Grade? Grade { get; set; }
        public int? GradeId { get; set; }
       
        public DateTime? HiringDate { get; set; }

        public bool? HouseHolder { get; set; }

        public float? LeavesBalance { get; set; }

        public DateTime? LeavesBalanceDate { get; set; }

        public int? NumberOfChildren { get; set; }

        public string? PhoneNumber { get; set; }
        public virtual ICollection<Project> Project { get; set; }

        public virtual Qualification? Qualification { get; set; }

        public int? QualificationId { get; set; }
        public string? RegistrationNumber { get; set; }

        public float? Salary { get; set; }

        public string? Sex { get; set; }
        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

       
        public string? UserName { get; set; }
        public string? Password { get; set; }
       
        public bool? SuperUser { get; set; }

       
        public virtual Profil? Profil { get; set; }
        public int? ProfilId { get; set; }
        


    }
}
