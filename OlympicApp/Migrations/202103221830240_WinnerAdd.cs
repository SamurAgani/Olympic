namespace OlympicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WinnerAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Races", "Winner_Id", c => c.Int());
            AddColumn("dbo.RaceForTeams", "Winner_Id", c => c.Int());
            CreateIndex("dbo.Races", "Winner_Id");
            CreateIndex("dbo.RaceForTeams", "Winner_Id");
            AddForeignKey("dbo.Races", "Winner_Id", "dbo.Athlets", "Id");
            AddForeignKey("dbo.RaceForTeams", "Winner_Id", "dbo.Teams", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RaceForTeams", "Winner_Id", "dbo.Teams");
            DropForeignKey("dbo.Races", "Winner_Id", "dbo.Athlets");
            DropIndex("dbo.RaceForTeams", new[] { "Winner_Id" });
            DropIndex("dbo.Races", new[] { "Winner_Id" });
            DropColumn("dbo.RaceForTeams", "Winner_Id");
            DropColumn("dbo.Races", "Winner_Id");
        }
    }
}
