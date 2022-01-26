namespace ConsoleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phoneAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Phone");
        }
    }
}
