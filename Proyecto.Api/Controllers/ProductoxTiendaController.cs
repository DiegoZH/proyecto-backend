using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Model;
using Proyecto.Queries.Producto;
using Proyecto.Queries.ProductoxTienda;
using Proyecto.Repository;
using Proyecto.ViewModel;

namespace Proyecto.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoxTiendaController : ControllerBase
    {
        private readonly IProductoxTiendaQueries _productoxTiendaQueries;
        private readonly IProductoxTiendaRepository _productoxTiendaRepository;
        public ProductoxTiendaController(IProductoxTiendaQueries productoxTiendaQueries, IProductoxTiendaRepository productoxTiendaRepository)
        {
            _productoxTiendaQueries = productoxTiendaQueries;
            _productoxTiendaRepository = productoxTiendaRepository;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            var result = await _productoxTiendaQueries.GetAll();
            return Ok(result);
        }

        [HttpPost]
        [Route("GetByFilters")]
        public async Task<ActionResult> GetByFilters([FromBody] FiltroProductoxTienda filtro)
        {
            var result = await _productoxTiendaQueries.GetByFilters(filtro);
            return Ok(result);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult> Create([FromBody] ProductoxTienda productoxTienda)
        {
            var result = await _productoxTiendaRepository.Create(productoxTienda);
            return Ok(result);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult> Update([FromBody] ProductoxTienda productoxTienda)
        {
            var result = await _productoxTiendaRepository.Update(productoxTienda);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<ActionResult> GetById([FromRoute] int id)
        {
            var result = await _productoxTiendaQueries.GetById(id);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            var result = await _productoxTiendaRepository.Delete(id);
            return Ok(result);
        }
    }
}
