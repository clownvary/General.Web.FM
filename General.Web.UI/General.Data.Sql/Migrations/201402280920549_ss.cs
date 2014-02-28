namespace General.Data.Sql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ss : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Dog", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "Dog");
        }
    }
}
