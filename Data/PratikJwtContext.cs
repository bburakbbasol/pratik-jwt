using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using pratik_jwt.Model;

namespace pratik_jwt.Data
{
    public class PratikJwtContext : IdentityDbContext<User>
    {
        public PratikJwtContext(DbContextOptions<PratikJwtContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
