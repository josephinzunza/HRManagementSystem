using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class ChangeStatesTaxesTableNameToStateTaxes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StatesTaxes_States_StateId",
                table: "StatesTaxes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatesTaxes",
                table: "StatesTaxes");

            migrationBuilder.RenameTable(
                name: "StatesTaxes",
                newName: "StateTaxes");

            migrationBuilder.RenameIndex(
                name: "IX_StatesTaxes_StateId",
                table: "StateTaxes",
                newName: "IX_StateTaxes_StateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StateTaxes",
                table: "StateTaxes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StateTaxes_States_StateId",
                table: "StateTaxes",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StateTaxes_States_StateId",
                table: "StateTaxes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StateTaxes",
                table: "StateTaxes");

            migrationBuilder.RenameTable(
                name: "StateTaxes",
                newName: "StatesTaxes");

            migrationBuilder.RenameIndex(
                name: "IX_StateTaxes_StateId",
                table: "StatesTaxes",
                newName: "IX_StatesTaxes_StateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatesTaxes",
                table: "StatesTaxes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StatesTaxes_States_StateId",
                table: "StatesTaxes",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
