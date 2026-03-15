using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class PopulateTimeOffTypesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(table: "TimeOffTypes", columns: ["Id", "Name"],
                values: new object[,]
                {
                    { 1, "Paid Time Off" },
                    { 2, "Sick Leave" },
                    { 3, "Personal Time" },
                    { 4, "Bereavement Leave" },
                    { 5, "Maternity/Paternity Leave" },
                    { 6, "Family and Medical Leave" },
                    { 7, "Jury Duty" },
                    { 8, "Military Leave" },
                    { 9, "Religious Observance Leave" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM TimeOffTypes");
        }
    }
}
