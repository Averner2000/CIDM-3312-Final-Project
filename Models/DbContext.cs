using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models
{
    public class DragonContext : DbContext
    {
        public DragonContext (DbContextOptions<DragonContext> options)
            : base (options)
            {
            }
        
        public DbSet<Dragon> Dragons  {get; set;} = default!;
        public DbSet<Country> Countrys {get; set;} = default!;
        public DbSet<Allegiance> Allegiances {get; set;} = default!;

    }
}