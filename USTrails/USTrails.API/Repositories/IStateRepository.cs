using USTrails.API.Models.Domain;

namespace USTrails.API.Repositories
{
    public interface IStateRepository
    {
        Task<State> CreateAsync(State state);

        Task<List<State>> GetAllAsync();

        Task<State?> GetByIdAsync(Guid id);

        Task<State?> UpdateAsync(Guid id, State state);

        Task<State?> DeleteAsync(Guid id);
    }
}
