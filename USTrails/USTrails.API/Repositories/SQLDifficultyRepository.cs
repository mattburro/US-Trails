using Microsoft.EntityFrameworkCore;
using USTrails.API.Data;
using USTrails.API.Models.Domain;

namespace USTrails.API.Repositories
{
    public class SQLDifficultyRepository : IDifficultyRepository
    {
        private readonly USTrailsDbContext dbContext;

        public SQLDifficultyRepository(USTrailsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Difficulty>> GetAllAsync()
        {
            return await dbContext.Difficulties.ToListAsync();
        }

        public async Task<Difficulty?> GetByIdAsync(Guid id)
        {
            return await dbContext.Difficulties.SingleOrDefaultAsync(d => d.Id == id);
        }
    }
}
