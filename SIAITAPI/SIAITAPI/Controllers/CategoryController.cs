using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIAITAPI.Data;
using SIAITAPI.DTO;
using SIAITAPI.IServices;
using SIAITAPI.Models;

namespace SIAITAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class CategoryController : ControllerBase
    {
        private  ICategoryService CategoryService;
        public CategoryController(ICategoryService categoryService) => this.CategoryService = categoryService;

        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(typeof(List<CategoryDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult  Get()
        {
            IEnumerable<CategoryDTO> list = this.CategoryService.Get().Select(a => new CategoryDTO(a)) ;
            return Ok(list);
        }


        [Route("GetBYId/{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(CategoryDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult  GetById(int id)
        {
           CategoryDTO categoryDTO=new CategoryDTO(this.CategoryService.GetById(id));
          return Ok(categoryDTO);
        }

        [Route("Create")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ObjectResult Create(CategoryDTO categoryDTO)
        {
            Category category = this.CategoryService.Create(new Category(categoryDTO));
            return Ok(new CategoryDTO(category));
         
        }
        [Route("Update/{id}")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public  ObjectResult Update(int id, CategoryDTO categoryDTO)
        {
         
            categoryDTO = new CategoryDTO(this.CategoryService.Update(id,new Category(categoryDTO)));
            return Ok(categoryDTO);
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ObjectResult Delete(int id)
        {

            this.CategoryService.Delete(id);

            return  Ok(true);

        }
    }
}
