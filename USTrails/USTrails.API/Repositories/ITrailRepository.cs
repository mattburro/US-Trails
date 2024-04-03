using USTrails.API.Models.Domain;
using USTrails.API.Models.DTO;

namespace USTrails.API.Repositories
{
    public interface ITrailRepository
    {
        Task<Trail> CreateAsync(CreateTrailRequestDto requestDto);
        Task<List<Trail>> GetAllAsync();
        Task<Trail?> GetByIdAsync(Guid id);
    }
}
