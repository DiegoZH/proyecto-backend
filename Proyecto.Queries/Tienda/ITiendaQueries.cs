using Proyecto.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Queries.Tienda
{
    public interface ITiendaQueries
    {
        Task<IEnumerable<TiendaViewModel>> GetAll();
        Task<TiendaByIdViewModel> GetById(int id);
    }
}
