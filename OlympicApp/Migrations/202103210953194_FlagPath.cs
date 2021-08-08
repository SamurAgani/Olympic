namespace OlympicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FlagPath : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Countries", "FlagPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Countries", "FlagPath");
        }
    }
}
