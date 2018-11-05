namespace SocietyInABox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedPreviousAdminStructure : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.AdminPermissions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AdminPermissions",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        PermissionsName = c.String(),
                        EditPermission = c.Boolean(nullable: false),
                        RemovePermission = c.Boolean(nullable: false),
                        PostPermission = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
