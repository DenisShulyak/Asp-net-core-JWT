using AuthJWTLesson.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthJWTLesson.DataAccess
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                Username = "admin",
                Password = "123"
            });
        }
    }
}
