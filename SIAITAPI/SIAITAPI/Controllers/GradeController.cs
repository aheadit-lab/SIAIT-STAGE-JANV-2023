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
   
    public class GradeController : ControllerBase
    {
        private IGradeService GradeService;
        public GradeController(IGradeService GradeService) => this.GradeService = GradeService;

        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(typeof(List<GradeDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult Get()
        {
            IEnumerable<GradeDTO> list = this.GradeService.Get().Select(a => new GradeDTO(a));
            return Ok(list);
        }


        [Route("GetBYId/{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(GradeDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult GetById(int id)
        {
            GradeDTO GradeDTO = new GradeDTO(this.GradeService.GetById(id));
            return Ok(GradeDTO);
        }

        [Route("Create")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ObjectResult Create(GradeDTO GradeDTO)
        {
            Grade Grade = this.GradeService.Create(new Grade(GradeDTO));
            return Ok(new GradeDTO(Grade));

        }
        [Route("Update/{id}")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ObjectResult Update(int id, GradeDTO GradeDTO)
        {

            GradeDTO = new GradeDTO(this.GradeService.Update(id, new Grade(GradeDTO)));
            return Ok(GradeDTO);
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ObjectResult Delete(int id)
        {

            this.GradeService.Delete(id);

            return Ok(true);

        }
    }
}
