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
                Difficulty = dbContext.Difficulties.Single(d => d.Id == createRequest.DifficultyId),
                States = createRequest.StateIds.Select(id => dbContext.States.Single(s => s.Id ==  id)).ToList()
            };

            await dbContext.Trails.AddAsync(trail);
            await dbContext.SaveChangesAsync();

            return trail;
        }

        public async Task<List<Trail>> GetAllAsync(string? filterOn = null, string? filterValue = null,
            string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 10)
        {
            var trails = dbContext.Trails.AsQueryable();

            // Filtering
            if (!string.IsNullOrWhiteSpace(filterOn) && !string.IsNullOrWhiteSpace(filterValue))
            {
                trails = filterOn.ToLower().Trim() switch
                {
                    "name" => trails.Where(t => t.Name.ToLower().Contains(filterValue.ToLower())),
                    "length" => trails.Where(t => t.LengthInMi >= double.Parse(filterValue)),
                    "difficulty" => trails.Where(t => t.DifficultyId == short.Parse(filterValue)),
                    _ => throw new ArgumentException($"'{filterOn}' property doesn't exist or isn't supported for filtering.")
                };
            }

            // Sorting
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                trails = sortBy.ToLower().Trim() switch
                {
                    "name" => isAscending ? trails.OrderBy(t => t.Name) : trails.OrderByDescending(t => t.Name),
                    "length" => isAscending ? trails.OrderBy(t => t.LengthInMi) : trails.OrderByDescending(t => t.LengthInMi),
                    "difficulty" => isAscending ? trails.OrderBy(t => t.DifficultyId) : trails.OrderByDescending(t => t.DifficultyId),
                    _ => throw new ArgumentException($"'{sortBy}' property doesn't exist or isn't supported for sorting.")
                };
            }

            // Pagination
            trails = trails.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            return await trails.ToListAsync();
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

            if (updateRequest.Name != null) existingTrail.Name = updateRequest.Name;
            if (updateRequest.Description != null) existingTrail.Description = updateRequest.Description;
            if (updateRequest.LengthInMi != null) existingTrail.LengthInMi = updateRequest.LengthInMi.Value;
            if (updateRequest.TrailImageUrl != null) existingTrail.TrailImageUrl = updateRequest.TrailImageUrl;
            if (updateRequest.DifficultyId != null) existingTrail.Difficulty = dbContext.Difficulties.Single(d => d.Id == updateRequest.DifficultyId.Value);
            if (updateRequest.StateIds != null) existingTrail.States = updateRequest.StateIds.Select(id => dbContext.States.Single(s => s.Id == id)).ToList();

            await dbContext.SaveChangesAsync();

            return existingTrail;
        }

        public async Task<Trail?> DeleteAsync(Guid id)
        {
            var existingWalk = await GetByIdAsync(id);

            if ( existingWalk == null)
            {
                return null;
            }

            dbContext.Trails.Remove(existingWalk);
            await dbContext.SaveChangesAsync();

            return existingWalk;
        }
    }
}
