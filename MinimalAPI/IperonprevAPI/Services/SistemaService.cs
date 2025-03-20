using IperonprevAPI.Dominio;
using IperonprevAPI.Repository;

namespace IperonprevAPI.Services
{
    public class SistemaService
    {
        private readonly SistemaRepository repository;

        public SistemaService(SistemaRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Sistema?> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task<IEnumerable<Sistema?>> GetAll()
        {
            return await repository.GetAll();
        }
    }
}
