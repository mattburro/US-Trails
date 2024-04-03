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

        public async Task<Trail> CreateAsync(CreateTrailRequestDto requestDto)
        {
            var trail = new Trail
            {
                Id = Guid.NewGuid(),
                Name = requestDto.Name,
                Description = requestDto.Description,
                LengthInMi = requestDto.LengthInMi,
                TrailImageUrl = requestDto.TrailImageUrl,
                Difficulty = dbContext.Difficulties.Single(d => d.Id == requestDto.DifficultyId),
                States = requestDto.StateIds.Select(id => dbContext.States.Single(s => s.Id ==  id)).ToList()
            };

            await dbContext.Trails.AddAsync(trail);
            await dbContext.SaveChangesAsync();

            return trail;
        }

        public async Task<List<Trail>> GetAllAsync()
        {
            return await dbContext.Trails
                .ToListAsync();
        }

        public async Task<Trail?> GetByIdAsync(Guid id)
        {
            return await dbContext.Trails
                .SingleOrDefaultAsync(t => t.Id == id);
        }
    }
}
