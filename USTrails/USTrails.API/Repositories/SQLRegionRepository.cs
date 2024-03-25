using Microsoft.EntityFrameworkCore;
using USTrails.API.Data;
using USTrails.API.Models.Domain;

namespace USTrails.API.Repositories
{
    public class SQLRegionRepository : IRegionRepository
    {
        private readonly USTrailsDbContext dbContext;

        public SQLRegionRepository(USTrailsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Region>> GetAllAsync()
        {
            return await dbContext.Regions.ToListAsync();
        }

        public async Task<Region?> GetByIdAsync(Guid id)
        {
            return await dbContext.Regions.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<Region> CreateAsync(Region newRegion)
        {
            await dbContext.Regions.AddAsync(newRegion);
            await dbContext.SaveChangesAsync();

            return newRegion;
        }

        public async Task<Region?> UpdateAsync(Guid id, Region updatedRegion)
        {
            // Check if the region to update exists
            var existingRegion = await GetByIdAsync(id);

            if (existingRegion == null)
            {
                return null;
            }

            // Update existing region with new data
            existingRegion.Code = updatedRegion.Code;
            existingRegion.Name = updatedRegion.Name;
            existingRegion.RegionImageUrl = updatedRegion.RegionImageUrl;

            await dbContext.SaveChangesAsync();
            return existingRegion;
        }

        public async Task<Region?> DeleteAsync(Guid id)
        {
            // Check if the region to delete exists
            var existingRegion = await GetByIdAsync(id);

            if (existingRegion == null)
            {
                return null;
            }

            // Delete region
            dbContext.Regions.Remove(existingRegion);
            await dbContext.SaveChangesAsync();

            return existingRegion;
        }
    }
}
