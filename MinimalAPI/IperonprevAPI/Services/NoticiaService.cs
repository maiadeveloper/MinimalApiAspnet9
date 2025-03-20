using IperonprevAPI.Dominio;
using IperonprevAPI.Repository;

namespace IperonprevAPI.Services
{
    public class NoticiaService
    {
        private readonly NoticiaRepository repository;

        public NoticiaService(NoticiaRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Noticia?> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task<IEnumerable<Noticia?>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<IEnumerable<Noticia?>> GetTopDetaque()
        {
            return await repository.GetTopDetaque();
        }     
    }
}
