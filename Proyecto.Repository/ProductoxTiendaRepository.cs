using Dapper;
using Microsoft.Extensions.Configuration;
using Proyecto.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Repository
{
    public class ProductoxTiendaRepository : IProductoxTiendaRepository
    {
        private readonly string _connectionString;
        public ProductoxTiendaRepository(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:SQL"];
        }
        public async Task<int> Create(ProductoxTienda productoxTienda)
        {
            int result;
            var parameters = new DynamicParameters();
            parameters.Add("@IdProducto", productoxTienda.IdProducto);
            parameters.Add("@CodigoTienda", productoxTienda.CodigoTienda);
            parameters.Add("@Stock", productoxTienda.Stock);
            parameters.Add("@Demanda", productoxTienda.Demanda);
            parameters.Add("@FechaLlegadaAlmacen", productoxTienda.FechaLlegadaAlmacen);
            parameters.Add("@FechaSalidaAlmacen", productoxTienda.FechaSalidaAlmacen);
            parameters.Add("@DiasInventario", productoxTienda.DiasInventario);
            parameters.Add("@PrecioRemate", productoxTienda.PrecioRemate);
            parameters.Add("@CantidadComprada", productoxTienda.CantidadComprada);
            parameters.Add("@CantidadVendida", productoxTienda.CantidadVendida);
            parameters.Add("@CantidadVendidaRemate", productoxTienda.CantidadVendidaRemate);

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.ExecuteAsync("[dbo].[Usp_Ins_ProductoxTienda]", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return result;
        }

        public async Task<int> Update(ProductoxTienda productoxTienda)
        {
            int result;
            var parameters = new DynamicParameters();
            parameters.Add("@IdRegistro", productoxTienda.IdRegistro);
            parameters.Add("@IdProducto", productoxTienda.IdProducto);
            parameters.Add("@CodigoTienda", productoxTienda.CodigoTienda);
            parameters.Add("@Stock", productoxTienda.Stock);
            parameters.Add("@Demanda", productoxTienda.Demanda);
            parameters.Add("@FechaLlegadaAlmacen", productoxTienda.FechaLlegadaAlmacen);
            parameters.Add("@FechaSalidaAlmacen", productoxTienda.FechaSalidaAlmacen);
            parameters.Add("@DiasInventario", productoxTienda.DiasInventario);
            parameters.Add("@PrecioRemate", productoxTienda.PrecioRemate);
            parameters.Add("@CantidadComprada", productoxTienda.CantidadComprada);
            parameters.Add("@CantidadVendida", productoxTienda.CantidadVendida);
            parameters.Add("@CantidadVendidaRemate", productoxTienda.CantidadVendidaRemate);

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.ExecuteAsync("[dbo].[Ups_Upd_ProductoxTienda]", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return result;
        }
        public async Task<int> Delete(int id)
        {
            int result;
            var parameters = new DynamicParameters();
            parameters.Add("@IdRegistro", id);

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.ExecuteAsync("[dbo].[Usp_Del_ProductoxTienda]", parameters, commandType: CommandType.StoredProcedure);
            }

            return result;
        }
    }
}
