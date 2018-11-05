namespace SocietyInABox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeRoleModels : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1a8ba1cb-48fe-416c-86b2-f59c01fb07fe', N'ContentCreator@SocietyInABox.com', 0, N'AGvjlBilhFNh73mxAY7/Xc9qcSm6WlMGhzeR5GPL0Q/h3Bh1AG0/OJhvbPtiIZRvrA==', N'66cbf7b0-4d4f-4156-b104-11ef9bbcc37d', NULL, 0, 0, NULL, 1, 0, N'ContentCreator@SocietyInABox.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'26aa83fe-2b00-4593-a818-299c24446ea2', N'MemberManager@SocietyInABox.com', 0, N'AB9q38bhyOcicj/CbMmLKxCbRcdugzRZPLaqIZ/cv92losJiqZ0qqwoRnTCid03ckw==', N'7adbf363-d76e-4a4a-8a89-6f16a25610df', NULL, 0, 0, NULL, 1, 0, N'MemberManager@SocietyInABox.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fd651e6b-6538-44ef-909b-825dbb2031a0', N'PermissionsAdmin@SocietyInABox.com', 0, N'AItHuRoE42HVWgMYbjwZZ6oSEUCqNEqQXBOahkhb8FGcaQty4fymAfwaOJwzAkHKag==', N'163955d6-92d7-4d8b-a5e7-513273f477a0', NULL, 0, 0, NULL, 1, 0, N'PermissionsAdmin@SocietyInABox.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f75a5442-f111-4850-bcc7-ff0f9568286a', N'CanEditPermissions')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5d82ce51-0696-4ef9-97f1-9f77f5104ffa', N'CanCreateContent')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'77e0114b-33e4-4756-a608-d20870c39dab', N'CanManageMembers')

               INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1a8ba1cb-48fe-416c-86b2-f59c01fb07fe', N'5d82ce51-0696-4ef9-97f1-9f77f5104ffa')
               INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'26aa83fe-2b00-4593-a818-299c24446ea2', N'77e0114b-33e4-4756-a608-d20870c39dab')
               INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fd651e6b-6538-44ef-909b-825dbb2031a0', N'f75a5442-f111-4850-bcc7-ff0f9568286a')


                SET IDENTITY_INSERT [dbo].[Members] ON
                INSERT INTO [dbo].[Members] ([Id], [FirstName], [LastName], [DateOfBirth], [MembershipType], [UserName]) VALUES (2002, N'ContentCreator@SocietyInABox.com', N'ContentCreator@SocietyInABox.com', N'1990-01-01 00:00:00', N'Admin', N'ContentCreator@SocietyInABox.com')
                INSERT INTO [dbo].[Members] ([Id], [FirstName], [LastName], [DateOfBirth], [MembershipType], [UserName]) VALUES (2003, N'MemberManager@SocietyInABox.com', N'MemberManager@SocietyInABox.com', N'1990-01-01 00:00:00', N'Admin', N'MemberManager@SocietyInABox.com')
                INSERT INTO [dbo].[Members] ([Id], [FirstName], [LastName], [DateOfBirth], [MembershipType], [UserName]) VALUES (4004, N'PermissionEditor', N'PermissionEditor', N'1990-01-01 00:00:00', N'Admin', N'PermissionEditor')

                SET IDENTITY_INSERT [dbo].[Members] OFF

                ");

        }
        
        public override void Down()
        {
        }
    }
}
