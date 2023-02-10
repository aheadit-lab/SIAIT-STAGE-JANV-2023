using SIAITAPI.Models;

namespace SIAITAPI.DTO
{
    public class CivilStatusDTO
    {
        public CivilStatusDTO(CivilStatus civilStatus)
        {
            this.Id = civilStatus.Id;
            this.Name = civilStatus.Name;
            this.Code = civilStatus.Code;
            this.CreatedAt = civilStatus.CreatedAt;
            this.UpdatedAt = civilStatus.UpdatedAt;
        }

        public CivilStatusDTO()
        {
        }

        public string Code { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? UpdatedAt { get; set; }

    }
}
