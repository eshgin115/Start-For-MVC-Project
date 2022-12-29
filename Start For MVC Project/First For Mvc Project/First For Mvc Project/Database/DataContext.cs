using Microsoft.EntityFrameworkCore;

namespace First_For_Mvc_Project.Database
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options)
          : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly<Program>();
        }
    }
}
