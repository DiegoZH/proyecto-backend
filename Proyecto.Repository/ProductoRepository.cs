using Dapper;
using Microsoft.Extensions.Configuration;
using Proyecto.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly string _connectionString;
        public ProductoRepository(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:SQL"];
        }
        public async Task<int> Create(Producto producto)
        {
            int result;
            var parameters = new DynamicParameters();
            parameters.Add("@Nombre", producto.Nombre);
            parameters.Add("@Descripcion", producto.Descripcion);
            parameters.Add("@PrecioVenta", producto.PrecioVenta);
            parameters.Add("@PrecioCompra", producto.PrecioCompra);

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.ExecuteAsync("[dbo].[Usp_Ins_Producto]", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return result;
        }

        public async Task<int> Update(Producto producto)
        {
            int result;
            var parameters = new DynamicParameters();
            parameters.Add("@IdProducto", producto.IdProducto);
            parameters.Add("@Nombre", producto.Nombre);
            parameters.Add("@Descripcion", producto.Descripcion);
            parameters.Add("@PrecioVenta", producto.PrecioVenta);
            parameters.Add("@PrecioCompra", producto.PrecioCompra);

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.ExecuteAsync("[dbo].[Ups_Upd_Producto]", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return result;
        }
    }
}
