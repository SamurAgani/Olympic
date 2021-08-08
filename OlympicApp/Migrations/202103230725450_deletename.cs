namespace OlympicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletename : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Teams", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "Name", c => c.String());
        }
    }
}
