using Microsoft.EntityFrameworkCore;

namespace MoviesViewModelAss.Models
{
    public class MoviesDBContext:DbContext
    {
        public MoviesDBContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Movies> movies { get; set; }
    }
}
