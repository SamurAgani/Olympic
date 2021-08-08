namespace OlympicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAthletToCh : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SportCathegories", "Athlet_Id", "dbo.Athlets");
            DropIndex("dbo.SportCathegories", new[] { "Athlet_Id" });
            AddColumn("dbo.Athlets", "SportCathegory_Id", c => c.Int());
            CreateIndex("dbo.Athlets", "SportCathegory_Id");
            AddForeignKey("dbo.Athlets", "SportCathegory_Id", "dbo.SportCathegories", "Id");
            DropColumn("dbo.SportCathegories", "Athlet_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SportCathegories", "Athlet_Id", c => c.Int());
            DropForeignKey("dbo.Athlets", "SportCathegory_Id", "dbo.SportCathegories");
            DropIndex("dbo.Athlets", new[] { "SportCathegory_Id" });
            DropColumn("dbo.Athlets", "SportCathegory_Id");
            CreateIndex("dbo.SportCathegories", "Athlet_Id");
            AddForeignKey("dbo.SportCathegories", "Athlet_Id", "dbo.Athlets", "Id");
        }
    }
}
