using Microsoft.EntityFrameworkCore;

namespace API_Core.Models
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions<myContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> employees { get; set; } = null!;
    }
}
