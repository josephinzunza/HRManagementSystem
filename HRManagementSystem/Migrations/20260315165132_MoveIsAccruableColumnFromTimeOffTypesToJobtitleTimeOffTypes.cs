using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class MoveIsAccruableColumnFromTimeOffTypesToJobtitleTimeOffTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAccruable",
                table: "TimeOffTypes");

            migrationBuilder.AddColumn<bool>(
                name: "IsAccruable",
                table: "JobTitleTimeOffTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAccruable",
                table: "JobTitleTimeOffTypes");

            migrationBuilder.AddColumn<bool>(
                name: "IsAccruable",
                table: "TimeOffTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
