namespace DesktopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class verification : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserInfoes", "EmailVerified", c => c.Boolean(nullable: false));
            AddColumn("dbo.UserInfoes", "PhoneVerified", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserInfoes", "PhoneVerified");
            DropColumn("dbo.UserInfoes", "EmailVerified");
        }
    }
}
