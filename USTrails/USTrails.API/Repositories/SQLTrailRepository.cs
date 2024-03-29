using Microsoft.EntityFrameworkCore;
using USTrails.API.Data;
using USTrails.API.Models.Domain;

namespace USTrails.API.Repositories
{
    public class SQLTrailRepository : ITrailRepository
    {
        private readonly USTrailsDbContext dbContext;

        public SQLTrailRepository(USTrailsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Trail> CreateAsync(Trail trail)
        {
            await dbContext.Trails.AddAsync(trail);
            await dbContext.SaveChangesAsync();

            return trail;
        }

        public async Task<List<Trail>> GetAllAsync()
        {
            return await dbContext.Trails.Include("Difficulty").Include("State").ToListAsync();
        }

        public async Task<Trail?> GetByIdAsync(Guid id)
        {
            return await dbContext.Trails.Include("Difficulty").Include("State").SingleOrDefaultAsync(t => t.Id == id);
        }
    }
}
