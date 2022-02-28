namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class profilePicture : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "ProfilePicture", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "ProfilePicture");
        }
    }
}
