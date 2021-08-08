namespace OlympicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForTeamAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RaceForTeams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SportCathegory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SportCathegories", t => t.SportCathegory_Id)
                .Index(t => t.Id)
                .Index(t => t.SportCathegory_Id);
            
            CreateTable(
                "dbo.StageForTeams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.DateTime(nullable: false),
                        Race_Id = c.Int(),
                        RaceForTeam_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Races", t => t.Race_Id)
                .ForeignKey("dbo.RaceForTeams", t => t.RaceForTeam_Id)
                .Index(t => t.Id)
                .Index(t => t.Race_Id)
                .Index(t => t.RaceForTeam_Id);
            
            AddColumn("dbo.Teams", "StageForTeam_Id", c => c.Int());
            CreateIndex("dbo.Teams", "StageForTeam_Id");
            AddForeignKey("dbo.Teams", "StageForTeam_Id", "dbo.StageForTeams", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StageForTeams", "RaceForTeam_Id", "dbo.RaceForTeams");
            DropForeignKey("dbo.Teams", "StageForTeam_Id", "dbo.StageForTeams");
            DropForeignKey("dbo.StageForTeams", "Race_Id", "dbo.Races");
            DropForeignKey("dbo.RaceForTeams", "SportCathegory_Id", "dbo.SportCathegories");
            DropIndex("dbo.Teams", new[] { "StageForTeam_Id" });
            DropIndex("dbo.StageForTeams", new[] { "RaceForTeam_Id" });
            DropIndex("dbo.StageForTeams", new[] { "Race_Id" });
            DropIndex("dbo.StageForTeams", new[] { "Id" });
            DropIndex("dbo.RaceForTeams", new[] { "SportCathegory_Id" });
            DropIndex("dbo.RaceForTeams", new[] { "Id" });
            DropColumn("dbo.Teams", "StageForTeam_Id");
            DropTable("dbo.StageForTeams");
            DropTable("dbo.RaceForTeams");
        }
    }
}
