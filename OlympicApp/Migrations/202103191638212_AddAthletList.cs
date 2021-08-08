namespace OlympicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAthletList : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Athlets", "SportCathegory_Id", "dbo.SportCathegories");
            DropIndex("dbo.Athlets", new[] { "SportCathegory_Id" });
            CreateTable(
                "dbo.SportCathegoryAthlets",
                c => new
                    {
                        SportCathegory_Id = c.Int(nullable: false),
                        Athlet_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SportCathegory_Id, t.Athlet_Id })
                .ForeignKey("dbo.SportCathegories", t => t.SportCathegory_Id, cascadeDelete: true)
                .ForeignKey("dbo.Athlets", t => t.Athlet_Id, cascadeDelete: true)
                .Index(t => t.SportCathegory_Id)
                .Index(t => t.Athlet_Id);
            
            DropColumn("dbo.Athlets", "SportCathegory_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Athlets", "SportCathegory_Id", c => c.Int());
            DropForeignKey("dbo.SportCathegoryAthlets", "Athlet_Id", "dbo.Athlets");
            DropForeignKey("dbo.SportCathegoryAthlets", "SportCathegory_Id", "dbo.SportCathegories");
            DropIndex("dbo.SportCathegoryAthlets", new[] { "Athlet_Id" });
            DropIndex("dbo.SportCathegoryAthlets", new[] { "SportCathegory_Id" });
            DropTable("dbo.SportCathegoryAthlets");
            CreateIndex("dbo.Athlets", "SportCathegory_Id");
            AddForeignKey("dbo.Athlets", "SportCathegory_Id", "dbo.SportCathegories", "Id");
        }
    }
}
