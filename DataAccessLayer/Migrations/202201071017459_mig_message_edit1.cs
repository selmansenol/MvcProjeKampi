namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_message_edit1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "Draft", c => c.Boolean(nullable: false));
            AddColumn("dbo.Messages", "Status", c => c.Boolean(nullable: false));
            DropColumn("dbo.Messages", "IsDraft");
            DropColumn("dbo.Messages", "Trash");
            DropColumn("dbo.Messages", "IsImportant");
            DropColumn("dbo.Messages", "IsSpam");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "IsSpam", c => c.Boolean(nullable: false));
            AddColumn("dbo.Messages", "IsImportant", c => c.Boolean(nullable: false));
            AddColumn("dbo.Messages", "Trash", c => c.Boolean(nullable: false));
            AddColumn("dbo.Messages", "IsDraft", c => c.Boolean(nullable: false));
            DropColumn("dbo.Messages", "Status");
            DropColumn("dbo.Messages", "Draft");
        }
    }
}
