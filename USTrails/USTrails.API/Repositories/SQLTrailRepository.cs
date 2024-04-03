using Microsoft.EntityFrameworkCore;
using USTrails.API.Data;
using USTrails.API.Models.Domain;
using USTrails.API.Models.DTO;

namespace USTrails.API.Repositories
{
    public class SQLTrailRepository : ITrailRepository
    {
        private readonly USTrailsDbContext dbContext;

        public SQLTrailRepository(USTrailsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Trail> CreateAsync(CreateTrailRequestDto createRequest)
        {
            var trail = new Trail
            {
                Id = Guid.NewGuid(),
                Name = createRequest.Name,
                Description = createRequest.Description,
                LengthInMi = createRequest.LengthInMi,
                TrailImageUrl = createRequest.TrailImageUrl,
                DifficultyId = createRequest.DifficultyId,
                Difficulty = dbContext.Difficulties.Single(d => d.Id == createRequest.DifficultyId),
                StateIds = createRequest.StateIds,
                States = createRequest.StateIds.Select(id => dbContext.States.Single(s => s.Id ==  id)).ToList()
            };

            await dbContext.Trails.AddAsync(trail);
            await dbContext.SaveChangesAsync();

            return trail;
        }

        public async Task<List<Trail>> GetAllAsync()
        {
            return await dbContext.Trails.ToListAsync();
        }

        public async Task<Trail?> GetByIdAsync(Guid id)
        {
            return await dbContext.Trails.SingleOrDefaultAsync(t => t.Id == id);
        }

        public async Task<Trail?> UpdateAsync(Guid id, UpdateTrailRequestDto updateRequest)
        {
            var existingTrail = await GetByIdAsync(id);

            if (existingTrail ==  null)
            {
                return null;
            }

            existingTrail.Name = updateRequest.Name;
            existingTrail.Description = updateRequest.Description;
            existingTrail.LengthInMi = updateRequest.LengthInMi;
            existingTrail.TrailImageUrl = updateRequest.TrailImageUrl;
            existingTrail.DifficultyId = updateRequest.DifficultyId;
            existingTrail.Difficulty = dbContext.Difficulties.Single(d => d.Id == updateRequest.DifficultyId);
            existingTrail.StateIds = updateRequest.StateIds;
            existingTrail.States = updateRequest.StateIds.Select(id => dbContext.States.Single(s => s.Id == id)).ToList();

            await dbContext.SaveChangesAsync();

            return existingTrail;
        }
    }
}
