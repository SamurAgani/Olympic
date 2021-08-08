namespace OlympicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdas : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OppositeTeams", "Stage_Id", "dbo.Stages");
            DropIndex("dbo.OppositeTeams", new[] { "Stage_Id" });
            DropColumn("dbo.OppositeTeams", "Stage_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OppositeTeams", "Stage_Id", c => c.Int());
            CreateIndex("dbo.OppositeTeams", "Stage_Id");
            AddForeignKey("dbo.OppositeTeams", "Stage_Id", "dbo.Stages", "Id");
        }
    }
}
