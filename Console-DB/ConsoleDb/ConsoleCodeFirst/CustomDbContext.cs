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
    }
}
