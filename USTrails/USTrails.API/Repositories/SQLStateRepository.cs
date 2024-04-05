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

        public async Task<List<State>> GetAllAsync()
        {
            return await dbContext.States.ToListAsync();
        }

        public async Task<State?> GetByIdAsync(byte id)
        {
            return await dbContext.States.FirstOrDefaultAsync(r => r.Id == id);
        }
    }
}
