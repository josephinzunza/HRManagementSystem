using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class RenameEmployeePayableBenefitStatusesToEmployeeDeclinedPayableBenefits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "EmployeePayableBenefitStatuses", newName: "EmployeeDeclinedPayableBenefits");

            migrationBuilder.DropPrimaryKey(name: "PK_EmployeePayableBenefitStatuses", table: "EmployeeDeclinedPayableBenefits");
            migrationBuilder.AddPrimaryKey(name: "PK_EmployeeDeclinedPayableBenefits", table: "EmployeeDeclinedPayableBenefits", ["EmployeeId", "PayableBenefitId"]);

            migrationBuilder.DropForeignKey(name: "FK_EmployeePayableBenefitStatuses_Employees_EmployeeId", table: "EmployeeDeclinedPayableBenefits");
            migrationBuilder.DropForeignKey(name: "FK_EmployeePayableBenefitStatuses_PayableBenefits_PayableBenefitId", table: "EmployeeDeclinedPayableBenefits");
            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDeclinedPayableBenefits_Employees_EmployeeId",
                table: "EmployeeDeclinedPayableBenefits",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDeclinedPayableBenefits_PayableBenefits_PayableBenefitId",
                table: "EmployeeDeclinedPayableBenefits",
                column: "PayableBenefitId",
                principalTable: "PayableBenefits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameIndex(name: "IX_EmployeePayableBenefitStatuses_PayableBenefitId", newName: "IX_EmployeeDeclinedPayableBenefits_PayableBenefitId",
                table: "EmployeeDeclinedPayableBenefits");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "EmployeeDeclinedPayableBenefits", newName: "EmployeePayableBenefitStatuses");

            migrationBuilder.DropPrimaryKey(name: "PK_EmployeeDeclinedPayableBenefits", table: "EmployeePayableBenefitStatuses");
            migrationBuilder.AddPrimaryKey(name: "PK_EmployeePayableBenefitStatuses", table: "EmployeePayableBenefitStatuses", ["EmployeeId", "PayableBenefitId"]);
            
            migrationBuilder.DropForeignKey(name: "FK_EmployeeDeclinedPayableBenefits_Employees_EmployeeId", table: "EmployeePayableBenefitStatuses");
            migrationBuilder.DropForeignKey(name: "FK_EmployeeDeclinedPayableBenefits_PayableBenefits_PayableBenefitId", table: "EmployeePayableBenefitStatuses");
            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePayableBenefitStatuses_Employees_EmployeeId",
                table: "EmployeePayableBenefitStatuses",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePayableBenefitStatuses_PayableBenefits_PayableBenefitId",
                table: "EmployeePayableBenefitStatuses",
                column: "PayableBenefitId",
                principalTable: "PayableBenefits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameIndex(name: "IX_EmployeeDeclinedPayableBenefits_PayableBenefitId", newName: "IX_EmployeePayableBenefitStatuses_PayableBenefitId",
                table: "EmployeePayableBenefitStatuses");
        }
    }
}
