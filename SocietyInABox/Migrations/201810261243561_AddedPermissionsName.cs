namespace SocietyInABox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPermissionsName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdminPermissions", "PermissionsName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AdminPermissions", "PermissionsName");
        }
    }
}
