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
   
    public class CareerController : ControllerBase
    {
        private ICareerService CareerService;
        public CareerController(ICareerService CareerService) => this.CareerService = CareerService;

        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(typeof(List<CareerDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult Get()
        {
            IEnumerable<CareerDTO> list = this.CareerService.Get().Select(a => new CareerDTO(a));
            return Ok(list);
        }


        [Route("GetBYId/{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(CareerDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult GetById(int id)
        {
            CareerDTO CareerDTO = new CareerDTO(this.CareerService.GetById(id));
            return Ok(CareerDTO);
        }

        [Route("Create")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ObjectResult Create(CareerDTO CareerDTO)
        {
            Career Career = this.CareerService.Create(new Career(CareerDTO));
            return Ok(new CareerDTO(Career));

        }
        [Route("Update/{id}")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ObjectResult Update(int id, CareerDTO CareerDTO)
        {

            CareerDTO = new CareerDTO(this.CareerService.Update(id, new Career(CareerDTO)));
            return Ok(CareerDTO);
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ObjectResult Delete(int id)
        {

            this.CareerService.Delete(id);

            return Ok(true);

        }

    }
}
