using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddAndPopulateHasIncomeTaxColumnToStatesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasIncomeTax",
                table: "States",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.Sql("UPDATE States SET HasIncomeTax = CASE WHEN Name " +
                "IN ('Alaska', 'Florida', 'Nevada', 'New Hampshire', 'South Dakota', 'Tennessee', " +
                "'Texas', 'Washington', 'Wyoming') THEN 0 ELSE 1 END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasIncomeTax",
                table: "States");
        }
    }
}