using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public Roles Roles { get; set; }
        public bool EmailVerified { get; set; }
        public bool PhoneVerified { get; set; }
    }

    public enum Roles
    {
        Admin = 10,
        Manager = 20,
        Helper = 30
    }
}