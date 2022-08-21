using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementWebIdentity.Data.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'8a00d754-7718-498c-83a9-d42cbe535c4e', N'Admin', N'ADMIN', N'Admin@test.com', N'ADMIN@TEST.COM', 0, N'AQAAAAEAACcQAAAAEEWROb5pkToZpxHgVx1xosq4l2kg6iyq2ofH0XI7WjfL+m2X2cWsmOp3KZEf/5XP4Q==', N'5LIGT3DJSMDEPXF7U2HWO7YN3QQDZIDJ', N'd0d59626-e2ba-4179-bb1e-f2211c61fd92', NULL, 0, 0, NULL, 1, 0, N'Mohamed', N'Saleem', null)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from [security].[Users] Where Id = '8a00d754-7718-498c-83a9-d42cbe535c4e'");
        }
    }
}
