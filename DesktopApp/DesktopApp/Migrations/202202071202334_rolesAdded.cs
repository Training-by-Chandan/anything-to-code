namespace DesktopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rolesAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserInfoes", "Roles", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserInfoes", "Roles");
        }
    }
}
