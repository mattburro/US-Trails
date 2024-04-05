using USTrails.API.Models.Domain;

namespace USTrails.API.Repositories
{
    public interface IDifficultyRepository
    {
        Task<List<Difficulty>> GetAllAsync();
        Task<Difficulty> GetByIdAsync(byte id);
    }
}
