using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class RemovePayableBenefitStatusesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePayableBenefitStatuses_PayableBenefitsStatuses_PayableBenefitStatusId",
                table: "EmployeePayableBenefitStatuses");

            migrationBuilder.DropTable(
                name: "PayableBenefitsStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeePayableBenefitStatuses",
                table: "EmployeePayableBenefitStatuses");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePayableBenefitStatuses_PayableBenefitStatusId",
                table: "EmployeePayableBenefitStatuses");

            migrationBuilder.DropColumn(
                name: "PayableBenefitStatusId",
                table: "EmployeePayableBenefitStatuses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeePayableBenefitStatuses",
                table: "EmployeePayableBenefitStatuses",
                columns: [ "EmployeeId", "PayableBenefitId"]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeePayableBenefitStatuses",
                table: "EmployeePayableBenefitStatuses");

            migrationBuilder.AddColumn<byte>(
                name: "PayableBenefitStatusId",
                table: "EmployeePayableBenefitStatuses",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeePayableBenefitStatuses",
                table: "EmployeePayableBenefitStatuses",
                columns: [ "EmployeeId", "PayableBenefitId", "PayableBenefitStatusId" ]);

            migrationBuilder.CreateTable(
                name: "PayableBenefitsStatuses",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayableBenefitsStatuses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePayableBenefitStatuses_PayableBenefitStatusId",
                table: "EmployeePayableBenefitStatuses",
                column: "PayableBenefitStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePayableBenefitStatuses_PayableBenefitsStatuses_PayableBenefitStatusId",
                table: "EmployeePayableBenefitStatuses",
                column: "PayableBenefitStatusId",
                principalTable: "PayableBenefitsStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
