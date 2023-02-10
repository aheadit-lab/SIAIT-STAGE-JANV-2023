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
    public class QualificationController : ControllerBase
    {
        private IQualificationService QualificationService;
        public QualificationController(IQualificationService QualificationService) => this.QualificationService = QualificationService;

        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(typeof(List<QualificationDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult Get()
        {
            IEnumerable<QualificationDTO> list = this.QualificationService.Get().Select(a => new QualificationDTO(a));
            return Ok(list);
        }


        [Route("GetBYId/{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(QualificationDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult GetById(int id)
        {
            QualificationDTO QualificationDTO = new QualificationDTO(this.QualificationService.GetById(id));
            return Ok(QualificationDTO);
        }

        [Route("Create")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ObjectResult Create(QualificationDTO QualificationDTO)
        {
            Qualification Qualification = this.QualificationService.Create(new Qualification(QualificationDTO));
            return Ok(new QualificationDTO(Qualification));

        }
        [Route("Update/{id}")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ObjectResult Update(int id, QualificationDTO QualificationDTO)
        {

            QualificationDTO = new QualificationDTO(this.QualificationService.Update(id, new Qualification(QualificationDTO)));
            return Ok(QualificationDTO);
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ObjectResult Delete(int id)
        {

            this.QualificationService.Delete(id);

            return Ok(true);

        }
    }
}
