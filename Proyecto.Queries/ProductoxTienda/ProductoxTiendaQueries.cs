using Dapper;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.Types.Sql.BackingStore;
using Microsoft.Extensions.Configuration;
using Proyecto.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Queries.ProductoxTienda
{
    public class ProductoxTiendaQueries : IProductoxTiendaQueries
    {
        private readonly string _connectionString;
        public ProductoxTiendaQueries(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:SQL"];
        }
        public async Task<IEnumerable<ProductoxTiendaViewModel>> GetAll()
        {
            IEnumerable<ProductoxTiendaViewModel> result = new List<ProductoxTiendaViewModel>();
            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.QueryAsync<ProductoxTiendaViewModel>("[dbo].[Usp_Sel_ProductoxTienda]", commandType: System.Data.CommandType.StoredProcedure);
            }
            return result;
        }

        public async Task<IEnumerable<ProductoxTiendaViewModel>> GetByFilters(int idProducto, int codigoTienda, int mes, int año)
        {
            IEnumerable<ProductoxTiendaViewModel> result = new List<ProductoxTiendaViewModel>();
            var parameters = new DynamicParameters();
            parameters.Add("@IdProducto", idProducto);
            parameters.Add("@CodigoTienda", codigoTienda);
            parameters.Add("@Mes", mes);
            parameters.Add("@Anio", año);
            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.QueryAsync<ProductoxTiendaViewModel>("[dbo].[Ups_Sel_FiltroProductoxTienda]", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return result;
        }
    }
}
