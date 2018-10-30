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

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5d82ce51-0696-4ef9-97f1-9f77f5104ffa', N'CanCreateContent')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'77e0114b-33e4-4756-a608-d20870c39dab', N'CanManageMembers')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1a8ba1cb-48fe-416c-86b2-f59c01fb07fe', N'5d82ce51-0696-4ef9-97f1-9f77f5104ffa')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'26aa83fe-2b00-4593-a818-299c24446ea2', N'77e0114b-33e4-4756-a608-d20870c39dab')
                ");

        }
        
        public override void Down()
        {
        }
    }
}
