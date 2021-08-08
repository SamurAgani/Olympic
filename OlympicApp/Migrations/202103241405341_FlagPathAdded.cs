namespace OlympicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FlagPathAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "FlagPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "FlagPath");
        }
    }
}
