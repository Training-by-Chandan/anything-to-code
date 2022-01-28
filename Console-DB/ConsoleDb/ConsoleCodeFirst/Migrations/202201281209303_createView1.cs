namespace ConsoleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class createView1 : DbMigration
    {
        public override void Up()
        {
            Sql("drop view vw_Test ");
        }

        public override void Down()
        {
            Sql("create view vw_Test as " +
                "select s.id, s.Name, s.Email, c.ClassName from students s " +
                "join classes c " +
                "on s.classid=c.id");
        }
    }
}