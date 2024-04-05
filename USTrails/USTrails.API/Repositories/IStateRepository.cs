using USTrails.API.Models.Domain;

namespace USTrails.API.Repositories
{
    public interface IStateRepository
    {
        Task<List<State>> GetAllAsync();

        Task<State?> GetByIdAsync(byte id);
    }
}
