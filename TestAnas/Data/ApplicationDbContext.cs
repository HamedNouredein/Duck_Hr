using Microsoft.EntityFrameworkCore;
using TestAnas.Models;

namespace TestAnas.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        public DbSet<Duck> Ducks { get; set; }
       public DbSet<Cycle> Cycles { get; set; }
       public DbSet<Farm> Farms { get; set; }
       public DbSet<Vaccine> Vaccines { get; set; }
        
    }
}
