namespace OlympicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImagePathAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Athlets", "CountryFlagImagePath", c => c.String());
            AddColumn("dbo.Athlets", "ImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Athlets", "ImagePath");
            DropColumn("dbo.Athlets", "CountryFlagImagePath");
        }
    }
}
