using DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Repository
{
    public class UserInfoRepository
    {
        private readonly InventoryContext db;

        public UserInfoRepository()
        {
            this.db = new InventoryContext();
        }

        public UserInfo GetUserByEmail(string email)
        {
            return db.UserInfo.FirstOrDefault(p => p.Email == email);
        }
    }
}