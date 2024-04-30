using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaseManagementFile.Migrations
{
    /// <inheritdoc />
    public partial class Number : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Patients",
                type: "int",
                nullable: false, // 允许 NULL 值
                 defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Patients");
        }
    }
}
