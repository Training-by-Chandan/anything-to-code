using ConsoleCodeFirst.Model;
using System.Data.Entity;

namespace ConsoleCodeFirst
{
    public class CustomDbContext : DbContext
    {
        public CustomDbContext() : base("name=Default")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}