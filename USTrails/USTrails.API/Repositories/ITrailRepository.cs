using USTrails.API.Models.Domain;
using USTrails.API.Models.DTO;

namespace USTrails.API.Repositories
{
    public interface ITrailRepository
    {
        Task<Trail> CreateAsync(CreateTrailRequestDto createRequest);
        Task<List<Trail>> GetAllAsync();
        Task<Trail?> GetByIdAsync(Guid id);
        Task<Trail?> UpdateAsync(Guid id, UpdateTrailRequestDto updateRequest);
        Task<Trail?> DeleteAsync(Guid id);
    }
}
