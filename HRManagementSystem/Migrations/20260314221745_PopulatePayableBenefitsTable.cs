using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class PopulatePayableBenefitsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(table: "PayableBenefits", columns: ["Id", "Name", "IsInsurance"],
                values: new object[,]
                {
                    { 1, "Health Insurance", true },
                    { 2, "Vision Insurance", true },
                    { 3, "Dental Insurance", true },
                    { 4, "Life Insurance", true },
                    { 5, "Disability Insurance", true },
                    { 6, "401(k)", false },
                    { 7, "403(b)", false },
                    { 8, "457(b)", false },
                    { 9, "SIMPLE IRA", false },
                    { 10, "SEP IRA", false },
                    { 11, "Health Savings Account (HSA)", false },
                    { 12, "Flexible Spending Account (FSA)", false },
                    { 13, "Health Reimbursement Account (HRA)", false },
                    { 14, "Educational Assistance Program", false },
                    { 15, "Profit-Sharing Plan", false },
                    { 16, "Dependent Care FSA", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM PayableBenefits");
        }
    }
}
