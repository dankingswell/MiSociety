namespace SocietyInABox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPermissionsData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into AdminPermissions ( PermissionsName, EditPermission, RemovePermission, PostPermission) VALUES( 'Service',1, 0,0)");
            Sql("Insert into AdminPermissions ( PermissionsName, EditPermission, RemovePermission, PostPermission) Values( 'Admin',1, 1,0)");
            Sql("Insert into AdminPermissions ( PermissionsName, EditPermission, RemovePermission, PostPermission) Values( 'Content-Creator',0, 0,1)");
            Sql("Insert into AdminPermissions ( PermissionsName, EditPermission, RemovePermission, PostPermission) Values( 'Global',1, 1,1)");
        }
        
        public override void Down()
        {
        }
    }
}
