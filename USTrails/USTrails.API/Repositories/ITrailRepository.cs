using USTrails.API.Models.Domain;
using USTrails.API.Models.DTO;

namespace USTrails.API.Repositories
{
    public interface ITrailRepository
    {
        Task<Trail> CreateAsync(AddTrailRequestDto requestDto);
        Task<List<Trail>> GetAllAsync();
        Task<Trail?> GetByIdAsync(Guid id);
    }
}
