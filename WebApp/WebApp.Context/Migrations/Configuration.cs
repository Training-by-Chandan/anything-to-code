namespace WebApp.Context.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApp.Models.ApplicationDbContext db)
        {
            var roleAdmin = new IdentityRole("Admin");
            var roleStudent = new IdentityRole("Student");
            var roleTeacher = new IdentityRole("Teacher");
            if (!db.Roles.Any(p => p.Name.ToUpper() == "ADMIN"))
            {
                db.Roles.Add(roleAdmin);
            }
            if (!db.Roles.Any(p => p.Name.ToUpper() == roleStudent.Name.ToUpper()))
            {
                db.Roles.Add(roleStudent);
            }
            if (!db.Roles.Any(p => p.Name.ToUpper() == roleTeacher.Name.ToUpper()))
            {
                db.Roles.Add(roleTeacher);
            }

            db.SaveChanges();
            var hasher = new PasswordHasher();

            var userStore = new UserStore<ApplicationUser>(db);
            var usermanager = new UserManager<ApplicationUser>(userStore);
            if (!db.Users.Any(p => p.UserName == "admin@admin.com"))
            {
                var adminUser = new Models.ApplicationUser() { UserName = "admin@admin.com", PasswordHash = hasher.HashPassword("Admin@123"), Email = "admin@admin.com", EmailConfirmed = true };
                // db.Users.Add(adminUser);

                usermanager.Create(adminUser);
                usermanager.AddToRole(adminUser.Id, roleAdmin.Name);
            }
            if (!db.Users.Any(p => p.UserName == "student@student.com"))
            {
                var studentUser = new Models.ApplicationUser() { UserName = "student@student.com", PasswordHash = hasher.HashPassword("Student@123"), Email = "student@student.com", EmailConfirmed = true };
                // db.Users.Add(adminUser);

                usermanager.Create(studentUser);
                usermanager.AddToRole(studentUser.Id, roleStudent.Name);
            }
            if (!db.Users.Any(p => p.UserName == "teacher@teacher.com"))
            {
                var teacherUser = new Models.ApplicationUser() { UserName = "teacher@teacher.com", PasswordHash = hasher.HashPassword("Teacher@123"), Email = "teacher@teacher.com", EmailConfirmed = true };
                // db.Users.Add(adminUser);

                usermanager.Create(teacherUser);
                usermanager.AddToRole(teacherUser.Id, roleTeacher.Name);
            }
        }
    }
}