using SIAITAPI.DTO;
using System.ComponentModel.DataAnnotations;

namespace SIAITAPI.Models
{
    public class Career
    {
        public Career(Collaborator collab)
        {
            if (collab.Category != null)
            { Category = collab.Category; }

            Bban = collab.Bban;

            if (collab.CivilStatus != null)
            { CivilStatus = collab.CivilStatus; }

            

            CategoryId = collab.CategoryId;

            GradeId = collab.GradeId;

            QualificationId = collab.QualificationId;

            CivilStatusId = collab.CivilStatusId;

            CreatedAt = DateTime.Now;

            UpdatedAt = DateTime.Now;
            From = DateTime.Now;

            HouseHolder = collab.HouseHolder;

            NumberOfChildren = collab.NumberOfChildren;

            if (collab.Qualification != null)
            { Qualification = collab.Qualification; }

            Salary = collab.Salary;

            if (collab.Grade != null)
            { Grade = collab.Grade; }

            CollaboratorId = collab.Id;

            To = null;

        }
        public Career(CareerDTO careerDTO)
        {
            Id = careerDTO.Id;

            if (careerDTO.Category != null)
            { Category = new Category(careerDTO.Category); }

            Bban = careerDTO.Bban;

            if (careerDTO.CivilStatus != null)
            { CivilStatus = new CivilStatus(careerDTO.CivilStatus); }

            if (careerDTO.Collaborator != null)
            { Collaborator = new Collaborator(careerDTO.Collaborator); }

            CategoryId = careerDTO.CategoryId;

            GradeId = careerDTO.GradeId;

            QualificationId = careerDTO.QualificationId;

            CivilStatusId = careerDTO.CivilStatusId;

            CreatedAt = careerDTO.CreatedAt;

            UpdatedAt = careerDTO.UpdatedAt;
            From = careerDTO.From;

            HouseHolder = careerDTO.HouseHolder;

            NumberOfChildren = careerDTO.NumberOfChildren;

            if (careerDTO.Qualification != null)
            { Qualification = new Qualification(careerDTO.Qualification); }

            Salary = careerDTO.Salary;

            if (careerDTO.Grade != null)
            { Grade = new Grade(careerDTO.Grade); }

            CollaboratorId= careerDTO.CollaboratorId;

            To = careerDTO.To;
        }
        public Career()
        {
        }

        public int Id { get; set; }
        [Required]
      
        public bool? HouseHolder { get; set; }
        public float? Salary { get; set; }
        public string? Bban { get; set; }
        public int? NumberOfChildren { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public virtual Category? Category { get; set; }
        public int? CategoryId { get; set; }
        public virtual CivilStatus? CivilStatus { get; set; }
        public int? CivilStatusId { get; set; }
        public virtual Collaborator? Collaborator { get; set; }
        public int? CollaboratorId { get; set; }
        public virtual Grade? Grade { get; set; }
        public int? GradeId { get; set; }
        public virtual Qualification? Qualification { get; set; }
        public int? QualificationId { get; set; }


    }

}
