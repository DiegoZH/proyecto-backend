using Dapper;
using Microsoft.Extensions.Configuration;
using Proyecto.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Queries.Producto
{
    public class ProductoQueries : IProductoQueries
    {
        private readonly string _connectionString;
        public ProductoQueries(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:SQL"];
        }
        public async Task<IEnumerable<ProductoViewModel>> GetAll()
        {
            IEnumerable<ProductoViewModel> result = new List<ProductoViewModel>();
            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.QueryAsync<ProductoViewModel>("[dbo].[Ups_Sel_Producto]", commandType: System.Data.CommandType.StoredProcedure);
            }
                return result;
        }

        public async Task<ProductoByIdViewModel> GetById(int id)
        {
            var productoByIdViewModel = new ProductoByIdViewModel();
            var parameters = new DynamicParameters();
            parameters.Add("@IdProducto", id);
            using (var connection = new SqlConnection(_connectionString))
            {
                productoByIdViewModel = await connection.QueryFirstOrDefaultAsync<ProductoByIdViewModel>("[dbo].[Usp_Sel_ProductoById]",parameters,commandType:System.Data.CommandType.StoredProcedure);
            }
            return productoByIdViewModel;
        }
    }
}
