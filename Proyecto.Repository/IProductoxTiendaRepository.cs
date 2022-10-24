using Proyecto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Repository
{
    public interface IProductoxTiendaRepository
    {
        Task<int> Create(ProductoxTienda productoxTienda);
        Task<int> Update(ProductoxTienda productoxTienda);
        Task<int> Delete(int id);
    }
}
