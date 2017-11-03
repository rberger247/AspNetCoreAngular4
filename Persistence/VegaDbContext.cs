using Microsoft.EntityFrameworkCore;
using vegaAttempt.Models;
using VegaAttempt.Models;

namespace vegaAttempt.Persistence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) 
          : base(options)
        {
        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}