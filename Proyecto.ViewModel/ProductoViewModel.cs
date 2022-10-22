using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ViewModel
{
    public class ProductoViewModel
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float PrecioVenta { get; set; }
        public float PrecioCompra { get; set; }
    }
}