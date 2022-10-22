using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Model;
using Proyecto.Queries.Producto;
using Proyecto.Queries.Tienda;
using Proyecto.Repository;

namespace Proyecto.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiendaController : ControllerBase
    {
        private readonly ITiendaQueries _tiendaQueries;
        private readonly ITiendaRepository _tiendaRepository;
        public TiendaController(ITiendaQueries tiendaQueries, ITiendaRepository tiendaRepository)
        {
            _tiendaQueries = tiendaQueries;
            _tiendaRepository = tiendaRepository;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            var result = await _tiendaQueries.GetAll();
            return Ok(result);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult> Create([FromBody] Tienda tienda)
        {
            var result = await _tiendaRepository.Create(tienda);
            return Ok(result);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult> Update([FromBody] Tienda tienda)
        {
            var result = await _tiendaRepository.Update(tienda);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult> GetById(int id)
        {
            var result = await _tiendaQueries.GetById(id);
            return Ok(result);
        }
    }

}
