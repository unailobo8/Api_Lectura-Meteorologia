using Microsoft.EntityFrameworkCore;

namespace Api_base.Models
{
    public class BalizaContext : DbContext
    {
        public BalizaContext(DbContextOptions<BalizaContext> options)
            : base(options)
        {
        }

        public DbSet<Balizas> Balizas { get; set; }
        
    }
}