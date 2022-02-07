namespace DesktopApp.Migrations
{
    using DesktopApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DesktopApp.Models.InventoryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DesktopApp.Models.InventoryContext db)
        {
            var admin = new UserInfo() { Email = "admin@admin.com", Password = "Admin@123", PhoneNumber = "9810315930", Roles = Roles.Admin };
            if (!db.UserInfo.Any(p => p.Email == admin.Email))
            {
                db.UserInfo.Add(admin);
                db.SaveChanges();
            }
        }
    }
}