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
    public class ProfilMenuController : ControllerBase
    {
        private IProfilMenuService ProfilMenuService;
        public ProfilMenuController(IProfilMenuService ProfilMenuService) => this.ProfilMenuService = ProfilMenuService;

        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(typeof(List<ProfilMenuDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult Get()
        {
            IEnumerable<ProfilMenuDTO> list = this.ProfilMenuService.Get().Select(a => new ProfilMenuDTO(a));
            return Ok(list);
        }


        [Route("GetBYId/{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(ProfilMenuDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult GetById(int id)
        {
            ProfilMenuDTO ProfilMenuDTO = new ProfilMenuDTO(this.ProfilMenuService.GetById(id));
            return Ok(ProfilMenuDTO);
        }

        [Route("Create")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ObjectResult Create(ProfilMenuDTO ProfilMenuDTO)
        {
            ProfilMenu ProfilMenu = this.ProfilMenuService.Create(new ProfilMenu(ProfilMenuDTO));
            return Ok(new ProfilMenuDTO(ProfilMenu));

        }
        [Route("Update/{id}")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ObjectResult Update(int id, ProfilMenuDTO ProfilMenuDTO)
        {

            ProfilMenuDTO = new ProfilMenuDTO(this.ProfilMenuService.Update(id, new ProfilMenu(ProfilMenuDTO)));
            return Ok(ProfilMenuDTO);
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ObjectResult Delete(int id)
        {

            this.ProfilMenuService.Delete(id);

            return Ok(true);

        }
    }
}
