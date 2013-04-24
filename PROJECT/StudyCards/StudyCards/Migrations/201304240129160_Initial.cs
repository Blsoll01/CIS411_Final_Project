namespace StudyCards.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "UserName");
        }
    }
}
