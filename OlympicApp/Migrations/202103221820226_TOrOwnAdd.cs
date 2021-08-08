namespace OlympicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TOrOwnAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeamOrOwns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TOrOwn = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.SportCathegories", "TeamOrOwn_Id", c => c.Int());
            CreateIndex("dbo.SportCathegories", "TeamOrOwn_Id");
            AddForeignKey("dbo.SportCathegories", "TeamOrOwn_Id", "dbo.TeamOrOwns", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SportCathegories", "TeamOrOwn_Id", "dbo.TeamOrOwns");
            DropIndex("dbo.SportCathegories", new[] { "TeamOrOwn_Id" });
            DropColumn("dbo.SportCathegories", "TeamOrOwn_Id");
            DropTable("dbo.TeamOrOwns");
        }
    }
}
