using SIAITAPI.Models;

namespace SIAITAPI.DTO
{
    public class QualificationDTO
    {
        public QualificationDTO(Qualification qualification)
        {
            this.Id = qualification.Id;
            this.Name = qualification.Name;
            this.Code = qualification.Code;
            this.CreatedAt = qualification.CreatedAt;
            this.UpdatedAt = qualification.UpdatedAt;
        }

    public QualificationDTO()
    {
    }

    public string Code { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int Id { get; set; }

    public string Name { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
}
