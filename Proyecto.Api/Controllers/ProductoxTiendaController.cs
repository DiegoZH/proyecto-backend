using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Queries.Producto;
using Proyecto.Queries.ProductoxTienda;
using Proyecto.Repository;

namespace Proyecto.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoxTiendaController : ControllerBase
    {
        private readonly IProductoxTiendaQueries _productoxTiendaQueries;
        public ProductoxTiendaController(IProductoxTiendaQueries productoxTiendaQueries)
        {
            _productoxTiendaQueries = productoxTiendaQueries;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            var result = await _productoxTiendaQueries.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetByFilters")]
        public async Task<ActionResult> GetByFilters(int idProducto, int codigoTienda, int mes, int año)
        {
            var result = await _productoxTiendaQueries.GetByFilters(idProducto, codigoTienda, mes, año);
            return Ok(result);
        }
    }
}
