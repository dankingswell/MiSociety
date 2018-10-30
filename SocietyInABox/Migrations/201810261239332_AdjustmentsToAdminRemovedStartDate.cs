namespace SocietyInABox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdjustmentsToAdminRemovedStartDate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AdminPermissions", "AdminFrom");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AdminPermissions", "AdminFrom", c => c.DateTime(nullable: false));
        }
    }
}
