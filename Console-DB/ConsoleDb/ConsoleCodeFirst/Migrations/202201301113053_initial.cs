namespace ConsoleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 20),
                        ClassId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClassId, cascadeDelete: true)
                .Index(t => t.ClassId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ClassId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Classes", t => t.ClassId, cascadeDelete: true)
                .Index(t => t.ClassId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.Students", "ClassId", "dbo.Classes");
            DropIndex("dbo.Teachers", new[] { "ClassId" });
            DropIndex("dbo.Students", new[] { "ClassId" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.Classes");
        }
    }
}
