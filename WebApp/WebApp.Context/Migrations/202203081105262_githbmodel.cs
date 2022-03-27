namespace WebApp.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class githbmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GithubModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Payloads = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GithubModels");
        }
    }
}
