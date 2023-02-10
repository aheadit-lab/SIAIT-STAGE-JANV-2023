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
    public class ProjectController : ControllerBase
    {
        private IProjetService ProjectService;
        public ProjectController(IProjetService ProjectService) => this.ProjectService = ProjectService;

        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(typeof(List<ProjectDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult Get()
        {
            IEnumerable<ProjectDTO> list = this.ProjectService.Get().Select(a => new ProjectDTO(a));
            return Ok(list);
        }


        [Route("GetBYId/{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(ProjectDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult GetById(int id)
        {
            ProjectDTO ProjectDTO = new ProjectDTO(this.ProjectService.GetById(id));
            return Ok(ProjectDTO);
        }

        [Route("Create")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ObjectResult Create(ProjectDTO ProjectDTO)
        {
            Project Project = this.ProjectService.Create(new Project(ProjectDTO));
            return Ok(new ProjectDTO(Project));

        }
        [Route("Update/{id}")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ObjectResult Update(int id, ProjectDTO ProjectDTO)
        {

            ProjectDTO = new ProjectDTO(this.ProjectService.Update(id, new Project(ProjectDTO)));
            return Ok(ProjectDTO);
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ObjectResult Delete(int id)
        {

            this.ProjectService.Delete(id);

            return Ok(true);

        }
    }
}
