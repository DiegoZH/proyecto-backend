using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Model;
using Proyecto.Queries.Producto;
using Proyecto.Repository;

namespace Proyecto.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoQueries _productoQueries;
        private readonly IProductoRepository _productoRepository;
        public ProductoController(IProductoQueries productoQueries, IProductoRepository productoRepository)
        {
            _productoQueries = productoQueries;
            _productoRepository = productoRepository;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            var result = await _productoQueries.GetAll();
            return Ok(result);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult> Create([FromBody] Producto producto)
        {
            var result = await _productoRepository.Create(producto);
            return Ok(result);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult> Update([FromBody] Producto producto)
        {
            var result = await _productoRepository.Update(producto);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult> GetById(int id)
        {
            var result = await _productoQueries.GetById(id);
            return Ok(result);
        }
    }
}
