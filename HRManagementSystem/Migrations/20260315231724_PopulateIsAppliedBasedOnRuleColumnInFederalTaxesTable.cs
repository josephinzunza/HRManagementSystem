using HRManagementSystem.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

#nullable disable

namespace HRManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class PopulateIsAppliedBasedOnRuleColumnInFederalTaxesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE FederalTaxes SET IsAppliedBasedOnRule = 1 Where Id = 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE FederalTaxes SET IsAppliedBasedOnRule = 1");
        }
    }
}
