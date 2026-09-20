using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quiz1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachears_DepartmentSet_DepartmentId",
                table: "Teachears");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentSet",
                table: "DepartmentSet");

            migrationBuilder.RenameTable(
                name: "DepartmentSet",
                newName: "Department");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentSet_Name",
                table: "Department",
                newName: "IX_Department_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachears_Department_DepartmentId",
                table: "Teachears",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachears_Department_DepartmentId",
                table: "Teachears");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "DepartmentSet");

            migrationBuilder.RenameIndex(
                name: "IX_Department_Name",
                table: "DepartmentSet",
                newName: "IX_DepartmentSet_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentSet",
                table: "DepartmentSet",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachears_DepartmentSet_DepartmentId",
                table: "Teachears",
                column: "DepartmentId",
                principalTable: "DepartmentSet",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
