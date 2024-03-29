using USTrails.API.Models.Domain;

namespace USTrails.API.Repositories
{
    public interface ITrailRepository
    {
        Task<Trail> CreateAsync(Trail trail);
        Task<List<Trail>> GetAllAsync();
        Task<Trail?> GetByIdAsync(Guid id);
    }
}
