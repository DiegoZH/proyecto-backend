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
    public class TiendaRepository : ITiendaRepository
    {
        private readonly string _connectionString;
        public TiendaRepository(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:SQL"];
        }
        public async Task<int> Create(Tienda tienda)
        {
            int result;
            var parameters = new DynamicParameters();
            parameters.Add("@Nombre", tienda.Nombre);
            parameters.Add("@Direccion", tienda.Direccion);
            parameters.Add("@Objetivo", tienda.Objetivo);

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.ExecuteAsync("[dbo].[Usp_Ins_Tienda]", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return result;
        }

        public async Task<int> Update(Tienda tienda)
        {
            int result;
            var parameters = new DynamicParameters();
            parameters.Add("@CodigoTienda", tienda.CodigoTienda);
            parameters.Add("@Nombre", tienda.Nombre);
            parameters.Add("@Direccion", tienda.Direccion);
            parameters.Add("@Objetivo", tienda.Objetivo);

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.ExecuteAsync("[dbo].[Ups_Upd_Tienda]", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return result;
        }
    }
}
