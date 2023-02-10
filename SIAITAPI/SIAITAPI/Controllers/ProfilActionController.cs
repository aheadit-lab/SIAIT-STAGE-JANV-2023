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
        public class ProfilActionController : ControllerBase
        {
        private IProfilActionService ProfilActionService;
        public ProfilActionController(IProfilActionService ProfilActionService) => this.ProfilActionService = ProfilActionService;

        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(typeof(List<ProfilActionDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult Get()
        {
            IEnumerable<ProfilActionDTO> list = this.ProfilActionService.Get().Select(a => new ProfilActionDTO(a));
            return Ok(list);
        }


        [Route("GetBYId/{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(ProfilActionDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult GetById(int id)
        {
            ProfilActionDTO ProfilActionDTO = new ProfilActionDTO(this.ProfilActionService.GetById(id));
            return Ok(ProfilActionDTO);
        }

        [Route("Create")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ObjectResult Create(ProfilActionDTO ProfilActionDTO)
        {
            ProfilAction ProfilAction = this.ProfilActionService.Create(new ProfilAction(ProfilActionDTO));
            return Ok(new ProfilActionDTO(ProfilAction));

        }
        [Route("Update/{id}")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ObjectResult Update(int id, ProfilActionDTO ProfilActionDTO)
        {

            ProfilActionDTO = new ProfilActionDTO(this.ProfilActionService.Update(id, new ProfilAction(ProfilActionDTO)));
            return Ok(ProfilActionDTO);
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ObjectResult Delete(int id)
        {

            this.ProfilActionService.Delete(id);

            return Ok(true);

        }
    }
    }


