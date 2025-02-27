using Microsoft.EntityFrameworkCore;

namespace HallBudgetMVC.Models
{
    public class HallDBContext:DbContext
    {
        public HallDBContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Hall> hall { get; set; }
    }
}
