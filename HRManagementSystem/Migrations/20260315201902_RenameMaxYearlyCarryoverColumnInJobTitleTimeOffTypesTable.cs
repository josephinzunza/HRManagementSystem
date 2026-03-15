using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class RenameMaxYearlyCarryoverColumnInJobTitleTimeOffTypesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaxYearlyCarryover",
                table: "JobTitleTimeOffTypes",
                newName: "AllowedYearlyCarryoverHours");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AllowedYearlyCarryoverHours",
                table: "JobTitleTimeOffTypes",
                newName: "MaxYearlyCarryover");
        }
    }
}
