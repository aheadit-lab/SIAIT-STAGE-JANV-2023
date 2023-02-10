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
   
    public class MenuController : ControllerBase
    {
        private IMenuService MenuService;
        public MenuController(IMenuService MenuService) => this.MenuService = MenuService;

        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(typeof(List<MenuDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult Get()
        {
            IEnumerable<MenuDTO> list = this.MenuService.Get().Select(a => new MenuDTO(a));
            return Ok(list);
        }


        [Route("GetBYId/{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(MenuDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult GetById(int id)
        {
            MenuDTO MenuDTO = new MenuDTO(this.MenuService.GetById(id));
            return Ok(MenuDTO);
        }

        [Route("Create")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ObjectResult Create(MenuDTO MenuDTO)
        {
            Menu Menu = this.MenuService.Create(new Menu(MenuDTO));
            return Ok(new MenuDTO(Menu));

        }
        [Route("Update/{id}")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ObjectResult Update(int id, MenuDTO MenuDTO)
        {

            MenuDTO = new MenuDTO(this.MenuService.Update(id, new Menu(MenuDTO)));
            return Ok(MenuDTO);
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ObjectResult Delete(int id)
        {

            this.MenuService.Delete(id);

            return Ok(true);

        }
    }
}
