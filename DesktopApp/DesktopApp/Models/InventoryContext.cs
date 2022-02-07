using System.Data.Entity;

namespace DesktopApp.Models
{
    public class InventoryContext : DbContext
    {
        public InventoryContext() : base("name=Inventory")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
    }
}