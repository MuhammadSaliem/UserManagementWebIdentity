using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementWebIdentity.Data.Migrations
{
    public partial class AssignAdminUserToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into [security].[UserRoles] (UserId, RoleId) SELECT '8a00d754-7718-498c-83a9-d42cbe535c4e', Id FROM [security].[Roles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[UserRoles] WHERE UserId = '8a00d754-7718-498c-83a9-d42cbe535c4e'");
        }
    }
}
