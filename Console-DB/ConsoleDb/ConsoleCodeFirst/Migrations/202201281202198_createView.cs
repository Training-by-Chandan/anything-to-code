namespace ConsoleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class createView : DbMigration
    {
        public override void Up()
        {
            Sql("create view vw_Test as " +
                "select s.id, s.Name, s.Email, c.ClassName from students s " +
                "join classes c " +
                "on s.classid=c.id");
        }

        public override void Down()
        {
            Sql("drop view vw_Test ");
        }
    }
}