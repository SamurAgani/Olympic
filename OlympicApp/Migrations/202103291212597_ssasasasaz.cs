namespace OlympicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ssasasasaz : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Athlets", "CountryFlagImagePath");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Athlets", "CountryFlagImagePath", c => c.String());
        }
    }
}
