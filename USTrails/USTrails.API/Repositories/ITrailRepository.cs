using USTrails.API.Models.Domain;
using USTrails.API.Models.DTO;

namespace USTrails.API.Repositories
{
    public interface ITrailRepository
    {
        Task<Trail> CreateAsync(CreateTrailRequestDto createRequest);
        Task<List<Trail>> GetAllAsync(string? filterOn = null, string? filterValue = null,
            string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 10);
        Task<Trail?> GetByIdAsync(Guid id);
        Task<Trail?> UpdateAsync(Guid id, UpdateTrailRequestDto updateRequest);
        Task<Trail?> DeleteAsync(Guid id);
    }
}
