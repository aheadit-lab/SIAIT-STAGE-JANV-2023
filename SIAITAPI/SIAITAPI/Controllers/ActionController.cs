using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIAITAPI.Data;
using SIAITAPI.DTO;
using Action = SIAITAPI.Models.Action;
using System.Linq;
using SIAITAPI.IServices;

namespace SIAITAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionController : ControllerBase
    {
        private IActionService ActionService;
        public ActionController(IActionService ActionService) => this.ActionService = ActionService;

        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(typeof(List<ActionDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult Get()
        {
            IEnumerable<ActionDTO> list = this.ActionService.Get().Select(a => new ActionDTO(a));
            return Ok(list);
        }


        [Route("GetBYId/{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(ActionDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult GetById(int id)
        {
            ActionDTO ActionDTO = new ActionDTO(this.ActionService.GetById(id));
            return Ok(ActionDTO);
        }

        [Route("Create")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ObjectResult Create(ActionDTO ActionDTO)
        {
            Action Action = this.ActionService.Create(new Action(ActionDTO));
            return Ok(new ActionDTO(Action));

        }
        [Route("Update/{id}")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ObjectResult Update(int id, ActionDTO ActionDTO)
        {

            ActionDTO = new ActionDTO(this.ActionService.Update(id, new Action(ActionDTO)));
            return Ok(ActionDTO);
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ObjectResult Delete(int id)
        {

            this.ActionService.Delete(id);

            return Ok(true);

        }

    }
}
