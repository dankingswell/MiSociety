namespace SocietyInABox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedAdminInfoInFavourOfRoleModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "AdminPermissions_Id", "dbo.AdminPermissions");
            DropIndex("dbo.Members", new[] { "AdminPermissions_Id" });
            DropColumn("dbo.Members", "IsAdmin");
            DropColumn("dbo.Members", "AdminPermissionsID");
            DropColumn("dbo.Members", "AdminPermissions_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "AdminPermissions_Id", c => c.Short());
            AddColumn("dbo.Members", "AdminPermissionsID", c => c.Byte(nullable: false));
            AddColumn("dbo.Members", "IsAdmin", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Members", "AdminPermissions_Id");
            AddForeignKey("dbo.Members", "AdminPermissions_Id", "dbo.AdminPermissions", "Id");
        }
    }
}
