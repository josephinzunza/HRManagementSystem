using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class PopulatePaymentPeriodTypesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(table: "PaymentPeriodTypes", columns: ["Id", "Name"],
                values: new object[,]
                {
                    { 1, "Weekly" },
                    { 2, "Biweekly" },
                    { 3, "Semimonthly" },
                    { 4, "Monthly" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM PaymentPeriodTypes");
        }
    }
}
