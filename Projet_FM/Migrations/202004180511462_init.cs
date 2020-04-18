namespace Projet_FM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cities", "Regions_Id", "dbo.Regions");
            DropForeignKey("dbo.Regions", "Countries_Id", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "Regions_Id" });
            DropIndex("dbo.Regions", new[] { "Countries_Id" });
            DropTable("dbo.Cities");
            DropTable("dbo.Regions");
            DropTable("dbo.Countries");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Language = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CountryId = c.Short(nullable: false),
                        Countries_Id = c.Short(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegionId = c.Int(nullable: false),
                        Name = c.String(),
                        Regions_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Regions", "Countries_Id");
            CreateIndex("dbo.Cities", "Regions_Id");
            AddForeignKey("dbo.Regions", "Countries_Id", "dbo.Countries", "Id");
            AddForeignKey("dbo.Cities", "Regions_Id", "dbo.Regions", "Id");
        }
    }
}
