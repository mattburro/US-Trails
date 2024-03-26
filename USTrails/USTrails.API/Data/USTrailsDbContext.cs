using Microsoft.EntityFrameworkCore;
using USTrails.API.Models.Domain;

namespace USTrails.API.Data
{
    public class USTrailsDbContext : DbContext
    {
        public USTrailsDbContext(DbContextOptions options) : base(options)
        { 
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Trail> Trails { get; set; }
    }
}
