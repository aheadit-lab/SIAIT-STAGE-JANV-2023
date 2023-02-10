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

    public class ModuleController : ControllerBase
    {
        private IModuleService ModuleService;
        public ModuleController(IModuleService ModuleService) => this.ModuleService = ModuleService;

        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(typeof(List<ModuleDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult Get()
        {
            IEnumerable<ModuleDTO> list = this.ModuleService.Get().Select(a => new ModuleDTO(a));
            return Ok(list);
        }


        [Route("GetBYId/{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(ModuleDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult GetById(int id)
        {
            ModuleDTO ModuleDTO = new ModuleDTO(this.ModuleService.GetById(id));
            return Ok(ModuleDTO);
        }

        [Route("Create")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ObjectResult Create(ModuleDTO ModuleDTO)
        {
            Module Module = this.ModuleService.Create(new Module(ModuleDTO));
            return Ok(new ModuleDTO(Module));

        }
        [Route("Update/{id}")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ObjectResult Update(int id, ModuleDTO ModuleDTO)
        {

            ModuleDTO = new ModuleDTO(this.ModuleService.Update(id, new Module(ModuleDTO)));
            return Ok(ModuleDTO);
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ObjectResult Delete(int id)
        {

            this.ModuleService.Delete(id);

            return Ok(true);

        }
    }
}
