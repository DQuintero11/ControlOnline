using ControlOnlineTest.Class;
using Microsoft.EntityFrameworkCore;

namespace ControlOnlineTest.DB
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Tasks> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<Tasks>().HasKey(t => t.id);  
        }
    }
}
