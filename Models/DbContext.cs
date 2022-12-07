using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models
{
    public class DragonDbContext : DbContext
    {
        public DragonDbContext (DbContextOptions<DragonDbContext> options)
            : base (options)
            {
            }
        
        public DbSet<Dragon> Dragons  {get; set;} = default!;
        public DbSet<Country> Countrys {get; set;} = default!;
        public DbSet<Allegiance> Allegiances {get; set;} = default!;

    }
}