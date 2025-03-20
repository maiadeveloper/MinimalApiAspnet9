using Dapper;
using IperonprevAPI.Dominio;
using Microsoft.Data.SqlClient;
using System.Data;

namespace IperonprevAPI.Repository
{
    public class SistemaRepository
    {
        private readonly string connectionString;

        public SistemaRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task<Sistema?> GetById(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();

                var sistema = await dbConnection.QueryFirstOrDefaultAsync<Sistema>("SELECT * FROM Sistema WHERE Id = @Id", new { Id = id });

                return sistema;
            }
        }

        public async Task<IEnumerable<Sistema?>> GetAll()
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();

                var sistemas = await dbConnection.QueryAsync<Sistema>("SELECT * FROM Sistema s ORDER BY s.NomeSistema");

                return sistemas;
            }
        }
    }
}
