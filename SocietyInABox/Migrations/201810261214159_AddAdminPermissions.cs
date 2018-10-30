namespace SocietyInABox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdminPermissions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminPermissions",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        RemovePermission = c.Boolean(nullable: false),
                        EditPermission = c.Boolean(nullable: false),
                        PostPermission = c.Boolean(nullable: false),
                        AdminFrom = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Members", "AdminPermissionsID", c => c.Byte(nullable: false));
            AddColumn("dbo.Members", "AdminPermissions_Id", c => c.Short());
            CreateIndex("dbo.Members", "AdminPermissions_Id");
            AddForeignKey("dbo.Members", "AdminPermissions_Id", "dbo.AdminPermissions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "AdminPermissions_Id", "dbo.AdminPermissions");
            DropIndex("dbo.Members", new[] { "AdminPermissions_Id" });
            DropColumn("dbo.Members", "AdminPermissions_Id");
            DropColumn("dbo.Members", "AdminPermissionsID");
            DropTable("dbo.AdminPermissions");
        }
    }
}
