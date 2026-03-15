using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class PopulateFederalTaxesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(table: "FederalTaxes", columns: ["Id", "Name", "Rate"],
                values: new object[,]
                {
                    { 1, "Social Security", 6.2m },
                    { 2, "Medicare", 1.45m }
                });
        }   

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM FederalTaxes");
        }
    }
}
