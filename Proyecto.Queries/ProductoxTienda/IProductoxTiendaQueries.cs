using Microsoft.Analytics.Types.Sql.BackingStore;
using Proyecto.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Queries.ProductoxTienda
{
    public interface IProductoxTiendaQueries
    {
        Task<IEnumerable<ProductoxTiendaViewModel>> GetAll();
        Task<IEnumerable<ProductoxTiendaViewModel>> GetByFilters(int idProducto, int codigoTienda, int mes, int año);
    }
}
