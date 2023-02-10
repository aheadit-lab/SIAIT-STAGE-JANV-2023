using SIAITAPI.Models;

namespace SIAITAPI.DTO
{
    public class GradeDTO
    {
        public GradeDTO(Grade grade)
        {
            this.Id = grade.Id;
            this.Name = grade.Name;
            this.Code = grade.Code;
            this.CreatedAt = grade.CreatedAt;
            this.UpdatedAt = grade.UpdatedAt;
        }

        public GradeDTO()
        {
        }

        public string Code { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
