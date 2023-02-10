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
    
    public class EntityController : ControllerBase
    {
        private IEntityService EntityService;
        public EntityController(IEntityService EntityService) => this.EntityService = EntityService;

        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(typeof(List<EntityDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult Get()
        {
            IEnumerable<EntityDTO> list = this.EntityService.Get().Select(a => new EntityDTO(a));
            return Ok(list);
        }


        [Route("GetBYId/{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(EntityDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult GetById(int id)
        {
            EntityDTO EntityDTO = new EntityDTO(this.EntityService.GetById(id));
            return Ok(EntityDTO);
        }

        [Route("Create")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ObjectResult Create(EntityDTO EntityDTO)
        {
            Entity Entity = this.EntityService.Create(new Entity(EntityDTO));
            return Ok(new EntityDTO(Entity));

        }
        [Route("Update/{id}")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ObjectResult Update(int id, EntityDTO EntityDTO)
        {

            EntityDTO = new EntityDTO(this.EntityService.Update(id, new Entity(EntityDTO)));
            return Ok(EntityDTO);
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ObjectResult Delete(int id)
        {

            this.EntityService.Delete(id);

            return Ok(true);

        }
    }
}
