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
        Task<IEnumerable<ProductoxTiendaByFiltersViewModel>> GetByFilters(FiltroProductoxTienda filtro);
        Task<ProductoxTiendaByFiltersViewModel> GetById(int id);
    }
}
