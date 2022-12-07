using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models
{
    public class DbContext : DbContext
    {
        public DbContext (DbContextOptions<DbContext> options)
            : base (options)
            {
            }
        
        public DbSet<Dragon> Dragons  {get; set;} = default!;
        public DbSet<Country> Countrys {get; set;} = default!;
        public DbSet<Allegiance> Allegiances {get; set;} = default!;

    }
}