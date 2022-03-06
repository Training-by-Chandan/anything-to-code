using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Linq;
using WebApp.Models;

namespace WebApp.Repository
{
    public interface IUserRepository
    {
        bool AssignUserToRole(string userId, string roleName);

        (bool, ApplicationUser) CreateUser(ApplicationUser user);
    }

    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext db;
        private readonly UserStore<ApplicationUser> userStore;
        private readonly UserManager<ApplicationUser> userManager;

        public UserRepository(
            ApplicationDbContext db
            )
        {
            this.db = db;
            userStore = new UserStore<ApplicationUser>(db);
            userManager = new UserManager<ApplicationUser>(userStore);
        }

        public (bool, ApplicationUser) CreateUser(ApplicationUser user)
        {
            try
            {
                var result = userManager.Create(user);
                if (result.Succeeded)
                {
                    return (true, user);
                }
                return (false, null);
            }
            catch (System.Exception ex)
            {
                return (false, null);
            }
        }

        public bool AssignUserToRole(string userId, string roleName)
        {
            try
            {
                var result = userManager.AddToRole(userId, roleName);
                if (result.Succeeded)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}