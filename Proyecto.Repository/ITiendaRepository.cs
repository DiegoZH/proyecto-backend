using Proyecto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Repository
{
    public interface ITiendaRepository
    {
        Task<int> Create(Tienda tienda);
        Task<int> Update(Tienda tienda);
        Task<int> Delete(int id);
    }
}
