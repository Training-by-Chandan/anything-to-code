namespace ConsoleCodeFirst.Migrations
{
    using ConsoleCodeFirst.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConsoleCodeFirst.CustomDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ConsoleCodeFirst.CustomDbContext db)
        {
            var class1 = new Classes() { ClassName = "Class One" };
            var class2 = new Classes() { ClassName = "Class Two" };
            var class3 = new Classes() { ClassName = "Class Three" };
            var class4 = new Classes() { ClassName = "Class Four" };
            var class5 = new Classes() { ClassName = "Class Five" };

            var existing = db.Classes.FirstOrDefault(p => p.ClassName == class1.ClassName);
            if (existing == null)
            {
                db.Classes.Add(class1);
            }
            existing = db.Classes.FirstOrDefault(p => p.ClassName == class2.ClassName);
            if (existing == null)
            {
                db.Classes.Add(class2);
            }
            existing = db.Classes.FirstOrDefault(p => p.ClassName == class3.ClassName);
            if (existing == null)
            {
                db.Classes.Add(class3);
            }
            existing = db.Classes.FirstOrDefault(p => p.ClassName == class4.ClassName);
            if (existing == null)
            {
                db.Classes.Add(class4);
            }
            existing = db.Classes.FirstOrDefault(p => p.ClassName == class5.ClassName);
            if (existing == null)
            {
                db.Classes.Add(class5);
            }
            db.SaveChanges();
        }
    }
}