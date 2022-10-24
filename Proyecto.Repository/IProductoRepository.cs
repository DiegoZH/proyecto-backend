using Proyecto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Repository
{
    public interface IProductoRepository
    {
        Task<int> Create(Producto producto);
        Task<int> Update(Producto producto);
        Task<int> Delete(int id);
    }
}
