namespace OlympicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondAndThirdAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Races", "Second_Id", c => c.Int());
            AddColumn("dbo.Races", "Third_Id", c => c.Int());
            AddColumn("dbo.RaceForTeams", "Second_Id", c => c.Int());
            AddColumn("dbo.RaceForTeams", "Third_Id", c => c.Int());
            CreateIndex("dbo.Races", "Second_Id");
            CreateIndex("dbo.Races", "Third_Id");
            CreateIndex("dbo.RaceForTeams", "Second_Id");
            CreateIndex("dbo.RaceForTeams", "Third_Id");
            AddForeignKey("dbo.Races", "Second_Id", "dbo.Athlets", "Id");
            AddForeignKey("dbo.Races", "Third_Id", "dbo.Athlets", "Id");
            AddForeignKey("dbo.RaceForTeams", "Second_Id", "dbo.Teams", "Id");
            AddForeignKey("dbo.RaceForTeams", "Third_Id", "dbo.Teams", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RaceForTeams", "Third_Id", "dbo.Teams");
            DropForeignKey("dbo.RaceForTeams", "Second_Id", "dbo.Teams");
            DropForeignKey("dbo.Races", "Third_Id", "dbo.Athlets");
            DropForeignKey("dbo.Races", "Second_Id", "dbo.Athlets");
            DropIndex("dbo.RaceForTeams", new[] { "Third_Id" });
            DropIndex("dbo.RaceForTeams", new[] { "Second_Id" });
            DropIndex("dbo.Races", new[] { "Third_Id" });
            DropIndex("dbo.Races", new[] { "Second_Id" });
            DropColumn("dbo.RaceForTeams", "Third_Id");
            DropColumn("dbo.RaceForTeams", "Second_Id");
            DropColumn("dbo.Races", "Third_Id");
            DropColumn("dbo.Races", "Second_Id");
        }
    }
}
