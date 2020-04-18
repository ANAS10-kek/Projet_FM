namespace Projet_FM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Country", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "State", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "City", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "City");
            DropColumn("dbo.AspNetUsers", "State");
            DropColumn("dbo.AspNetUsers", "Country");
        }
    }
}
