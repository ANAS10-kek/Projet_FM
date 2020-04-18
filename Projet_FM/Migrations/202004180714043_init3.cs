namespace Projet_FM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MailViewModels", "Email_M", c => c.String(nullable: false));
            AddColumn("dbo.MailViewModels", "Name_M", c => c.String(nullable: false));
            AddColumn("dbo.MailViewModels", "Subject_M", c => c.String(nullable: false));
            AddColumn("dbo.MailViewModels", "Message_M", c => c.String(nullable: false));
            DropColumn("dbo.MailViewModels", "Email");
            DropColumn("dbo.MailViewModels", "Name");
            DropColumn("dbo.MailViewModels", "Subject");
            DropColumn("dbo.MailViewModels", "Message");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MailViewModels", "Message", c => c.String(nullable: false));
            AddColumn("dbo.MailViewModels", "Subject", c => c.String(nullable: false));
            AddColumn("dbo.MailViewModels", "Name", c => c.String(nullable: false));
            AddColumn("dbo.MailViewModels", "Email", c => c.String(nullable: false));
            DropColumn("dbo.MailViewModels", "Message_M");
            DropColumn("dbo.MailViewModels", "Subject_M");
            DropColumn("dbo.MailViewModels", "Name_M");
            DropColumn("dbo.MailViewModels", "Email_M");
        }
    }
}
