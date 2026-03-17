using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class PopulateStateTaxesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(table: "StateTaxes", columns: ["Id", "StateId", "Description", "Rate", "IsAppliedBasedOnRule"],
                values: new object[,] {
                    { 1, 2, "Employment Security Tax (SUI)", 0.50m, true },
                    { 2, 5, "Mental Health Services Act", 1.00m, true },
                    { 3, 5, "State Disability Insurance (CASDI)", 1.30m, false },
                    { 4, 6, "Family and Medical Leave Insurance (FAMLI)", 0.44m, true },
                    { 5, 7, "Paid Leave (CTPL)", 0.50m, true },
                    { 6, 8, "Paid Leave", 0.40m, true },
                    { 7, 11, "Temporary Disability Insurance", 0.50m, true },
                    { 8, 19, "Paid Family and Medical Leave", 0.50m, true },
                    { 9, 21, "Millionaire Surtax", 4.00m, true},
                    { 10, 21, "Paid Family and Medical Leave", 0.46m, true },
                    { 11, 23, "Paid Leave", 0.44m, true },
                    { 12, 32, "Paid Family Leave", 0.432m, true },
                    { 13, 37, "Paid Leave", 0.60m, true },
                    { 14, 38, "Unemployment Compensation", 0.07m, false },
                    { 15, 39, "Temporary Disability / Caregiver Insurance", 1.10m, true },
                    { 16, 45, "Child Care Contribution", 0.44m, false },
                    { 17, 47, "Paid Family and Medical Leave", 0.807m, true },
                    { 18, 47, "WA Cares Fund", 0.58m, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM StateTaxes");
        }
    }
}
