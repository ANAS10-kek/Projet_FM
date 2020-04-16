namespace Projet_FM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.MailViewModels");
            AlterColumn("dbo.MailViewModels", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.MailViewModels", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.MailViewModels");
            AlterColumn("dbo.MailViewModels", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.MailViewModels", "Id");
        }
    }
}
