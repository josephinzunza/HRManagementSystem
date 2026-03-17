using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class PopulateFederalTaxesTableAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(table: "FederalTaxes", columns: ["Id", "Name", "Rate", "IsAppliedBasedOnRule"],
                values: new object[,]
                {
                    { 3, "Additional Medicare", 0.9m, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(table: "FederalTaxes", keyColumn: "Id", 3);
        }
    }
}
