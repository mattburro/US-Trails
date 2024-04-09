using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace USTrails.API.Data
{
    public class USTrailsAuthDbContext : IdentityDbContext
    {
        public USTrailsAuthDbContext(DbContextOptions<USTrailsAuthDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed role data
            var readerRoleId = "dfbcdc2f-7a38-407d-b76a-c759df22e090";
            var writerRoleId = "b78629aa-ea0b-45a8-806c-cdd3e5370dab";
            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = readerRoleId,
                    Name = "Reader",
                    NormalizedName = "READER"
                },
                new IdentityRole
                {
                    Id = writerRoleId,
                    Name = "Writer",
                    NormalizedName = "WRITER"
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
