using Microsoft.EntityFrameworkCore;
using ProjectEntityFramework.Models.EfTestModel;

namespace ProjectEntityFramework.Data
{
    public class DataContext : DbContext
    {
        
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
       

        // Override OnConfiguring only if options are not already configured
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(
                    "Server=localhost;Database=entity;User=root;Password=;",
                    new MySqlServerVersion(new Version(8, 0, 21))
                );
            }
        }
         public DbSet<Student> Students { get; set; }
    }
}
