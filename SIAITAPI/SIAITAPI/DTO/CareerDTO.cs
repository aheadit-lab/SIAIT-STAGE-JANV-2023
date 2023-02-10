using SIAITAPI.Models;

namespace SIAITAPI.DTO
{
    public class CareerDTO
    {
        
        public CareerDTO(Career career) 
        {
            Id = career.Id;
            if (career.Category != null)
            { Category = new CategoryDTO(career.Category); }
            Bban = career.Bban;
            if (career.CivilStatus != null)
            { CivilStatus = new CivilStatusDTO(career.CivilStatus); }
            if (career.Collaborator != null)
            { Collaborator = new CollaboratorDTO(career.Collaborator); }
            CategoryId = career.CategoryId;
            GradeId = career.GradeId;
            QualificationId = career.QualificationId;
            CivilStatusId = career.CivilStatusId;
            CreatedAt = career.CreatedAt;
            UpdatedAt = career.UpdatedAt;
            From = career.From;
            HouseHolder = career.HouseHolder;
            NumberOfChildren = career.NumberOfChildren;
            if (career.Qualification != null)
            { Qualification = new QualificationDTO(career.Qualification); }
            Salary = career.Salary;
            if (career.Grade != null)
            { Grade = new GradeDTO(career.Grade); }
            To= career.To;
            CollaboratorId = career.CollaboratorId;
        }
        public CareerDTO() { }



        public int Id { get; set; }
    
        public bool? HouseHolder { get; set; }
        public float? Salary { get; set; }
        public string? Bban { get; set; }
        public int? NumberOfChildren { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public virtual CategoryDTO? Category { get; set; }
        public int? CategoryId { get; set; }
        public virtual CivilStatusDTO? CivilStatus { get; set; }
        public int? CivilStatusId { get; set; }
        public virtual CollaboratorDTO? Collaborator { get; set; }
        public int? CollaboratorId { get; set; }
        public virtual GradeDTO? Grade { get; set; }
        public int? GradeId { get; set; }
        public virtual QualificationDTO? Qualification{ get; set; }
        public int? QualificationId { get; set; }

    }
}
