using Dapper;
using Microsoft.Extensions.Configuration;
using Proyecto.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Queries.Tienda
{
    public class TiendaQueries : ITiendaQueries
    {
        private readonly string _connectionString;
        public TiendaQueries(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:SQL"];
        }
        public async Task<IEnumerable<TiendaViewModel>> GetAll()
        {
            IEnumerable<TiendaViewModel> result = new List<TiendaViewModel>();
            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.QueryAsync<TiendaViewModel>("[dbo].[Ups_Sel_Tienda]", commandType: System.Data.CommandType.StoredProcedure);
            }
            return result;
        }

        public async Task<TiendaByIdViewModel> GetById(int id)
        {
            var productoByIdViewModel = new TiendaByIdViewModel();
            var parameters = new DynamicParameters();
            parameters.Add("@CodigoTienda", id);
            using (var connection = new SqlConnection(_connectionString))
            {
                productoByIdViewModel = await connection.QueryFirstOrDefaultAsync<TiendaByIdViewModel>("[dbo].[Usp_Sel_TiendaById]", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return productoByIdViewModel;
        }
    }
}
