using Dapper;
using IperonprevAPI.Dominio;
using Microsoft.Data.SqlClient;
using System.Data;

namespace IperonprevAPI.Repository
{
    public class NoticiaRepository
    {
        private readonly string connectionString;

        public NoticiaRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task<Noticia?> GetById(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();

                var noticia = await dbConnection.QueryFirstOrDefaultAsync<Noticia>("SELECT * FROM Noticia WHERE Id = @Id", new { Id = id });

                return noticia;
            }
        }

        public async Task<IEnumerable<Noticia?>> GetAll()
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();

                var noticias = await dbConnection.QueryAsync<Noticia>("SELECT * FROM Noticia");

                return noticias;
            }
        }

        public async Task<IEnumerable<Noticia?>> GetTopDetaque()
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();

                var noticias = await dbConnection.QueryAsync<Noticia>("SELECT TOP 10 * from Noticia n ORDER BY n.Id DESC");

                return noticias;
            }
        }
    }
}
