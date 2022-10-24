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

        public async Task<IEnumerable<ProductoxTiendaByFiltersViewModel>> GetByFilters(FiltroProductoxTienda filtro)
        {
            IEnumerable<ProductoxTiendaByFiltersViewModel> result = new List<ProductoxTiendaByFiltersViewModel>();
            var parameters = new DynamicParameters();
            if (filtro.NombreProducto == null)
            {
                filtro.NombreProducto = "";
            }
            if (filtro.NombreTienda == null)
            {
                filtro.NombreTienda = "";
            }
            parameters.Add("@NombreProducto", filtro.NombreProducto.ToUpper());
            parameters.Add("@NombreTienda", filtro.NombreTienda.ToUpper());
            parameters.Add("@Mes", filtro.Mes);
            parameters.Add("@Anio", filtro.Anio);
            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.QueryAsync<ProductoxTiendaByFiltersViewModel>("[dbo].[Ups_Sel_FiltroProductoxTienda]", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return result;
        }

        public async Task<ProductoxTiendaByFiltersViewModel> GetById(int id)
        {
            var productoxTiendaByIdViewModel = new ProductoxTiendaByFiltersViewModel();
            var parameters = new DynamicParameters();
            parameters.Add("@IdRegistro", id);
            using (var connection = new SqlConnection(_connectionString))
            {
                productoxTiendaByIdViewModel = await connection.QueryFirstOrDefaultAsync<ProductoxTiendaByFiltersViewModel>("[dbo].[Usp_Sel_ProductoxTiendaById]", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return productoxTiendaByIdViewModel;
        }
    }
}
