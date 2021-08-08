namespace OlympicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OltpicHasCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Athlets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SurName = c.String(),
                        Weight = c.Int(nullable: false),
                        BirthDay = c.DateTime(nullable: false),
                        Country_Id = c.Int(),
                        Gender_Id = c.Int(),
                        Stage_Id = c.Int(),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .ForeignKey("dbo.Genders", t => t.Gender_Id)
                .ForeignKey("dbo.Stages", t => t.Stage_Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Id)
                .Index(t => t.Country_Id)
                .Index(t => t.Gender_Id)
                .Index(t => t.Stage_Id)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Medals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TimeOfWon = c.DateTime(nullable: false),
                        MedalType_Id = c.Int(),
                        SportCathegory_Id = c.Int(),
                        Country_Id = c.Int(),
                        Athlet_Id = c.Int(),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MedalTypes", t => t.MedalType_Id)
                .ForeignKey("dbo.SportCathegories", t => t.SportCathegory_Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .ForeignKey("dbo.Athlets", t => t.Athlet_Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Id)
                .Index(t => t.MedalType_Id)
                .Index(t => t.SportCathegory_Id)
                .Index(t => t.Country_Id)
                .Index(t => t.Athlet_Id)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.MedalTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.SportCathegories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender_Id = c.Int(),
                        Athlet_Id = c.Int(),
                        Sport_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genders", t => t.Gender_Id)
                .ForeignKey("dbo.Athlets", t => t.Athlet_Id)
                .ForeignKey("dbo.Sports", t => t.Sport_Id)
                .Index(t => t.Id)
                .Index(t => t.Gender_Id)
                .Index(t => t.Athlet_Id)
                .Index(t => t.Sport_Id);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FemaleOrMale = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.RaceDegrees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Place = c.Double(nullable: false),
                        Race_Id = c.Int(),
                        SportCathegory_Id = c.Int(),
                        Athlet_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Races", t => t.Race_Id)
                .ForeignKey("dbo.SportCathegories", t => t.SportCathegory_Id)
                .ForeignKey("dbo.Athlets", t => t.Athlet_Id)
                .Index(t => t.Id)
                .Index(t => t.Race_Id)
                .Index(t => t.SportCathegory_Id)
                .Index(t => t.Athlet_Id);
            
            CreateTable(
                "dbo.Races",
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
                "dbo.Stages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.DateTime(nullable: false),
                        Race_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Races", t => t.Race_Id)
                .Index(t => t.Id)
                .Index(t => t.Race_Id);
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country_Id = c.Int(),
                        SportCathegory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .ForeignKey("dbo.SportCathegories", t => t.SportCathegory_Id)
                .Index(t => t.Id)
                .Index(t => t.Country_Id)
                .Index(t => t.SportCathegory_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "SportCathegory_Id", "dbo.SportCathegories");
            DropForeignKey("dbo.Medals", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Teams", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Athlets", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.SportCathegories", "Sport_Id", "dbo.Sports");
            DropForeignKey("dbo.SportCathegories", "Athlet_Id", "dbo.Athlets");
            DropForeignKey("dbo.RaceDegrees", "Athlet_Id", "dbo.Athlets");
            DropForeignKey("dbo.RaceDegrees", "SportCathegory_Id", "dbo.SportCathegories");
            DropForeignKey("dbo.RaceDegrees", "Race_Id", "dbo.Races");
            DropForeignKey("dbo.Races", "SportCathegory_Id", "dbo.SportCathegories");
            DropForeignKey("dbo.Stages", "Race_Id", "dbo.Races");
            DropForeignKey("dbo.Athlets", "Stage_Id", "dbo.Stages");
            DropForeignKey("dbo.Medals", "Athlet_Id", "dbo.Athlets");
            DropForeignKey("dbo.Athlets", "Gender_Id", "dbo.Genders");
            DropForeignKey("dbo.Medals", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Medals", "SportCathegory_Id", "dbo.SportCathegories");
            DropForeignKey("dbo.SportCathegories", "Gender_Id", "dbo.Genders");
            DropForeignKey("dbo.Medals", "MedalType_Id", "dbo.MedalTypes");
            DropForeignKey("dbo.Athlets", "Country_Id", "dbo.Countries");
            DropIndex("dbo.Teams", new[] { "SportCathegory_Id" });
            DropIndex("dbo.Teams", new[] { "Country_Id" });
            DropIndex("dbo.Teams", new[] { "Id" });
            DropIndex("dbo.Sports", new[] { "Id" });
            DropIndex("dbo.Stages", new[] { "Race_Id" });
            DropIndex("dbo.Stages", new[] { "Id" });
            DropIndex("dbo.Races", new[] { "SportCathegory_Id" });
            DropIndex("dbo.Races", new[] { "Id" });
            DropIndex("dbo.RaceDegrees", new[] { "Athlet_Id" });
            DropIndex("dbo.RaceDegrees", new[] { "SportCathegory_Id" });
            DropIndex("dbo.RaceDegrees", new[] { "Race_Id" });
            DropIndex("dbo.RaceDegrees", new[] { "Id" });
            DropIndex("dbo.Genders", new[] { "Id" });
            DropIndex("dbo.SportCathegories", new[] { "Sport_Id" });
            DropIndex("dbo.SportCathegories", new[] { "Athlet_Id" });
            DropIndex("dbo.SportCathegories", new[] { "Gender_Id" });
            DropIndex("dbo.SportCathegories", new[] { "Id" });
            DropIndex("dbo.MedalTypes", new[] { "Id" });
            DropIndex("dbo.Medals", new[] { "Team_Id" });
            DropIndex("dbo.Medals", new[] { "Athlet_Id" });
            DropIndex("dbo.Medals", new[] { "Country_Id" });
            DropIndex("dbo.Medals", new[] { "SportCathegory_Id" });
            DropIndex("dbo.Medals", new[] { "MedalType_Id" });
            DropIndex("dbo.Medals", new[] { "Id" });
            DropIndex("dbo.Countries", new[] { "Id" });
            DropIndex("dbo.Athlets", new[] { "Team_Id" });
            DropIndex("dbo.Athlets", new[] { "Stage_Id" });
            DropIndex("dbo.Athlets", new[] { "Gender_Id" });
            DropIndex("dbo.Athlets", new[] { "Country_Id" });
            DropIndex("dbo.Athlets", new[] { "Id" });
            DropTable("dbo.Teams");
            DropTable("dbo.Sports");
            DropTable("dbo.Stages");
            DropTable("dbo.Races");
            DropTable("dbo.RaceDegrees");
            DropTable("dbo.Genders");
            DropTable("dbo.SportCathegories");
            DropTable("dbo.MedalTypes");
            DropTable("dbo.Medals");
            DropTable("dbo.Countries");
            DropTable("dbo.Athlets");
        }
    }
}
