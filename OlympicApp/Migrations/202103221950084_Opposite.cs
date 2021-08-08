namespace OlympicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Opposite : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teams", "StageForTeam_Id", "dbo.StageForTeams");
            DropIndex("dbo.Teams", new[] { "StageForTeam_Id" });
            CreateTable(
                "dbo.OppositeTeams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Stage_Id = c.Int(),
                        Team1_Id = c.Int(),
                        Team2_Id = c.Int(),
                        StageForTeam_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stages", t => t.Stage_Id)
                .ForeignKey("dbo.Teams", t => t.Team1_Id)
                .ForeignKey("dbo.Teams", t => t.Team2_Id)
                .ForeignKey("dbo.StageForTeams", t => t.StageForTeam_Id)
                .Index(t => t.Id)
                .Index(t => t.Stage_Id)
                .Index(t => t.Team1_Id)
                .Index(t => t.Team2_Id)
                .Index(t => t.StageForTeam_Id);
            
            DropColumn("dbo.Teams", "StageForTeam_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "StageForTeam_Id", c => c.Int());
            DropForeignKey("dbo.OppositeTeams", "StageForTeam_Id", "dbo.StageForTeams");
            DropForeignKey("dbo.OppositeTeams", "Team2_Id", "dbo.Teams");
            DropForeignKey("dbo.OppositeTeams", "Team1_Id", "dbo.Teams");
            DropForeignKey("dbo.OppositeTeams", "Stage_Id", "dbo.Stages");
            DropIndex("dbo.OppositeTeams", new[] { "StageForTeam_Id" });
            DropIndex("dbo.OppositeTeams", new[] { "Team2_Id" });
            DropIndex("dbo.OppositeTeams", new[] { "Team1_Id" });
            DropIndex("dbo.OppositeTeams", new[] { "Stage_Id" });
            DropIndex("dbo.OppositeTeams", new[] { "Id" });
            DropTable("dbo.OppositeTeams");
            CreateIndex("dbo.Teams", "StageForTeam_Id");
            AddForeignKey("dbo.Teams", "StageForTeam_Id", "dbo.StageForTeams", "Id");
        }
    }
}
