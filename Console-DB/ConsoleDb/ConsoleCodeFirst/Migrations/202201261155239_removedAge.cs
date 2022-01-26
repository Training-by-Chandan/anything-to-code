namespace ConsoleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedAge : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "Age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Age", c => c.Int(nullable: false));
        }
    }
}
