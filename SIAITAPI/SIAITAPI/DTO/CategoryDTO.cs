using SIAITAPI.Models;

namespace SIAITAPI.DTO
{
    public class CategoryDTO
    {
        public CategoryDTO(Category category)
        {
            this.Id = category.Id;
            this.Name = category.Name;
            this.Code = category.Code;
            this.CreatedAt = category.CreatedAt;
            this.UpdatedAt = category.UpdatedAt;
        }

        public CategoryDTO()
        {
        }

        public string Code { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}

