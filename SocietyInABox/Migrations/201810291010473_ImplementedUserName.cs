namespace SocietyInABox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImplementedUserName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "UserName", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "UserName");
        }
    }
}
