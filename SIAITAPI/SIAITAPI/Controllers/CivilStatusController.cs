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
   
    public class CivilStatusController : ControllerBase
    {
        private ICivilStatusService CivilStatusService;
        public CivilStatusController(ICivilStatusService CivilStatusService) => this.CivilStatusService = CivilStatusService;

        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(typeof(List<CivilStatusDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult Get()
        {
            IEnumerable<CivilStatusDTO> list = this.CivilStatusService.Get().Select(a => new CivilStatusDTO(a));
            return Ok(list);
        }


        [Route("GetBYId/{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(CivilStatusDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult GetById(int id)
        {
            CivilStatusDTO CivilStatusDTO = new CivilStatusDTO(this.CivilStatusService.GetById(id));
            return Ok(CivilStatusDTO);
        }

        [Route("Create")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ObjectResult Create(CivilStatusDTO CivilStatusDTO)
        {
            CivilStatus CivilStatus = this.CivilStatusService.Create(new CivilStatus(CivilStatusDTO));
            return Ok(new CivilStatusDTO(CivilStatus));

        }
        [Route("Update/{id}")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ObjectResult Update(int id, CivilStatusDTO CivilStatusDTO)
        {

            CivilStatusDTO = new CivilStatusDTO(this.CivilStatusService.Update(id, new CivilStatus(CivilStatusDTO)));
            return Ok(CivilStatusDTO);
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ObjectResult Delete(int id)
        {

            this.CivilStatusService.Delete(id);

            return Ok(true);

        }
    }
}
