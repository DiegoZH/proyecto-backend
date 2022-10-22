using Proyecto.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Queries.Producto
{
    public interface IProductoQueries
    {
        Task<IEnumerable<ProductoViewModel>> GetAll();
        Task<ProductoByIdViewModel> GetById(int id);
    }
}
