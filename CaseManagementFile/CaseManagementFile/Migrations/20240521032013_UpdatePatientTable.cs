using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaseManagementFile.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePatientTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
            name: "ExpectedTreatmentTime",
            table: "Patients",
            type: "nvarchar(max)",
            nullable: true,
            oldClrType: typeof(TimeSpan),
            oldType: "time",
            oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "RecentWeight",
                table: "Patients",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
            name: "ExpectedTreatmentTime",
            table: "Patients",
            type: "time",
            nullable: true,
            oldClrType: typeof(string),
            oldType: "nvarchar(max)",
            oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RecentWeight",
                table: "Patients",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");
        }
    }
}
