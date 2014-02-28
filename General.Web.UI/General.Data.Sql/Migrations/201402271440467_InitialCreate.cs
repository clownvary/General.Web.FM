namespace General.Data.Sql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Point = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Name = c.String(),
                        Sex = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Salary = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Name = c.String(),
                        Sex = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "TeacherId", "dbo.Teachers");
            DropIndex("dbo.Students", new[] { "TeacherId" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
        }
    }
}
