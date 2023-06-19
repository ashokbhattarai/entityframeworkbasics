using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreBasics.Migrations
{
    /// <inheritdoc />
    public partial class InitialSetupNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "tblEmployees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblEmployees",
                table: "tblEmployees",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblEmployees",
                table: "tblEmployees");

            migrationBuilder.RenameTable(
                name: "tblEmployees",
                newName: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");
        }
    }
}
