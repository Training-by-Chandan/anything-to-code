using DesktopApp.Repository;
using DesktopApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Service
{
    public class UserService
    {
        private readonly UserInfoRepository userInfoRepository;

        public UserService()
        {
            this.userInfoRepository = new UserInfoRepository();
        }

        public (bool, string) Login(LoginViewModel model)
        {
            var existingUser = userInfoRepository.GetUserByEmail(model.Username);
            if (existingUser == null)
                return (false, "User not found");

            if (model.Password != existingUser.Password)
                return (false, "Password doesnot match");

            if (!existingUser.EmailVerified)
                return (false, "Email is not verified");

            if (!existingUser.PhoneVerified)
                return (false, "Phone is not verified");

            return (true, "Logged in successfully");
        }
    }
}