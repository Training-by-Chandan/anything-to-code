using ConsoleCodeFirst.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.Configurations.Add(new ClassesMap());
        }
    }

    public class ClassesMap : EntityTypeConfiguration<Classes>
    {
        //public ClassesMap()
        //{
        //    this.HasKey(p => p.Id);
        //    this.HasRequired(p => p.Teachers).WithRequiredPrincipal(p => p.Class);
        //}
    }
}