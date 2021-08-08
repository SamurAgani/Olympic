namespace OlympicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStageToAthlet : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Athlets", "Stage_Id", "dbo.Stages");
            DropIndex("dbo.Athlets", new[] { "Stage_Id" });
            CreateTable(
                "dbo.StageAthlets",
                c => new
                    {
                        Stage_Id = c.Int(nullable: false),
                        Athlet_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Stage_Id, t.Athlet_Id })
                .ForeignKey("dbo.Stages", t => t.Stage_Id, cascadeDelete: true)
                .ForeignKey("dbo.Athlets", t => t.Athlet_Id, cascadeDelete: true)
                .Index(t => t.Stage_Id)
                .Index(t => t.Athlet_Id);
            
            DropColumn("dbo.Athlets", "Stage_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Athlets", "Stage_Id", c => c.Int());
            DropForeignKey("dbo.StageAthlets", "Athlet_Id", "dbo.Athlets");
            DropForeignKey("dbo.StageAthlets", "Stage_Id", "dbo.Stages");
            DropIndex("dbo.StageAthlets", new[] { "Athlet_Id" });
            DropIndex("dbo.StageAthlets", new[] { "Stage_Id" });
            DropTable("dbo.StageAthlets");
            CreateIndex("dbo.Athlets", "Stage_Id");
            AddForeignKey("dbo.Athlets", "Stage_Id", "dbo.Stages", "Id");
        }
    }
}
