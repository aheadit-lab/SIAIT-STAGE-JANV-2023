using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIAITAPI.Data;
using SIAITAPI.DTO;
using SIAITAPI.IServices;
using SIAITAPI.Models;
using SIAITAPI.Utils;
namespace SIAITAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  
    public class CollaboratorController : ControllerBase
    {
        private ICollaborateurService CollaborateurService;
        public CollaboratorController(ICollaborateurService CollaborateurService) => this.CollaborateurService = CollaborateurService;

        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(typeof(List<CollaboratorDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult Get()
        {
            IEnumerable<CollaboratorDTO> list = this.CollaborateurService.Get().Select(a => new CollaboratorDTO(a));
            return Ok(list);
        }


        [Route("GetBYId/{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(CollaboratorDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult GetById(int id)
        {
            CollaboratorDTO CollaborateurDTO = new CollaboratorDTO(this.CollaborateurService.GetById(id));
            return Ok(CollaborateurDTO);
        }

        [Route("Create")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ObjectResult Create(CollaboratorDTO CollaborateurDTO)
        {
            Collaborator Collaborateur = this.CollaborateurService.Create(new Collaborator(CollaborateurDTO));
            return Ok(new CollaboratorDTO(Collaborateur));

        }
        [Route("Update/{id}")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ObjectResult Update(int id, CollaboratorDTO CollaborateurDTO)
        {

            CollaborateurDTO = new CollaboratorDTO(this.CollaborateurService.Update(id, new Collaborator(CollaborateurDTO)));
            return Ok(CollaborateurDTO);
        }

        [Route("Login")]
        [HttpPost]
        [ProducesResponseType(typeof(LoginResponseDTO), StatusCodes.Status200OK)]
        public ObjectResult Login(string username, string password)
        {
            var collaborator = CollaborateurService.GetUserByLoginAndPwd(username, password);
            if (collaborator == null)
            {
                return Unauthorized("404 error");
            }
            string token = JWTManager.GenerateToken(collaborator);
            return Ok(new LoginResponseDTO
            {
                Collaborator=new CollaboratorDTO(collaborator),
                Token = token,
            });


        }


        [Route("Delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ObjectResult Delete(int id)
        {

            this.CollaborateurService.Delete(id);

            return Ok(true);

        }

        
    }
}
