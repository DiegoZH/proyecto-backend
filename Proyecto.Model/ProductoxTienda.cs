using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Model
{
    public class ProductoxTienda
    {
        public int IdRegistro { get; set; }
        public int IdProducto { get; set; }
        public int CodigoTienda { get; set; }
        public DateTime FechaLlegadaAlmacen { get; set; }
        public DateTime? FechaSalidaAlmacen { get; set; }
        public int? DiasInventario { get; set; }
        public float? PrecioRemate { get; set; }
        public int Demanda { get; set; }
        public int CantidadComprada { get; set; }
        public int? CantidadVendida { get; set; }
        public int? CantidadVendidaRemate { get; set; }
        public int Stock { get; set; }
    }
}
