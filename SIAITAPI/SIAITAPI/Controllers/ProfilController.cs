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
    public class ProfilController : ControllerBase
    {
        private IProfilService ProfilService;
        public ProfilController(IProfilService ProfilService) => this.ProfilService = ProfilService;

        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(typeof(List<ProfilDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult Get()
        {
            IEnumerable<ProfilDTO> list = this.ProfilService.Get().Select(a => new ProfilDTO(a));
            return Ok(list);
        }


        [Route("GetBYId/{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(ProfilDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult GetById(int id)
        {
            ProfilDTO ProfilDTO = new ProfilDTO(this.ProfilService.GetById(id));
            return Ok(ProfilDTO);
        }

        [Route("Create")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ObjectResult Create(ProfilDTO ProfilDTO)
        {
            Profil Profil = this.ProfilService.Create(new Profil(ProfilDTO));
            return Ok(new ProfilDTO(Profil));

        }
        [Route("Update/{id}")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ObjectResult Update(int id, ProfilDTO ProfilDTO)
        {

            ProfilDTO = new ProfilDTO(this.ProfilService.Update(id, new Profil(ProfilDTO)));
            return Ok(ProfilDTO);
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ObjectResult Delete(int id)
        {

            this.ProfilService.Delete(id);

            return Ok(true);

        }
    }
}
