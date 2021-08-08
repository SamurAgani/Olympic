namespace OlympicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdasdaa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Athlets", "FlagPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Athlets", "FlagPath");
        }
    }
}
