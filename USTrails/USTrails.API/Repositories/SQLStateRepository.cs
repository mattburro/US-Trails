using Microsoft.EntityFrameworkCore;
using USTrails.API.Data;
using USTrails.API.Models.Domain;

namespace USTrails.API.Repositories
{
    public class SQLStateRepository : IStateRepository
    {
        private readonly USTrailsDbContext dbContext;

        public SQLStateRepository(USTrailsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<State> CreateAsync(State newState)
        {
            await dbContext.States.AddAsync(newState);
            await dbContext.SaveChangesAsync();

            return newState;
        }

        public async Task<List<State>> GetAllAsync()
        {
            return await dbContext.States.ToListAsync();
        }

        public async Task<State?> GetByIdAsync(Guid id)
        {
            return await dbContext.States.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<State?> UpdateAsync(Guid id, State updatedState)
        {
            // Check if the state to update exists
            var existingState = await GetByIdAsync(id);

            if (existingState == null)
            {
                return null;
            }

            // Update existing state with new data
            existingState.Code = updatedState.Code;
            existingState.Name = updatedState.Name;
            existingState.StateImageUrl = updatedState.StateImageUrl;

            await dbContext.SaveChangesAsync();
            return existingState;
        }

        public async Task<State?> DeleteAsync(Guid id)
        {
            // Check if the state to delete exists
            var existingState = await GetByIdAsync(id);

            if (existingState == null)
            {
                return null;
            }

            // Delete state
            dbContext.States.Remove(existingState);
            await dbContext.SaveChangesAsync();

            return existingState;
        }
    }
}
