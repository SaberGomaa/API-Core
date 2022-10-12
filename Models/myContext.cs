using Microsoft.EntityFrameworkCore;

namespace API_Core.Models
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions<myContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source = SABER ; User Id = saber ; Password = 123456789;Initial catalog = APICoreTest;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }

    }
}
