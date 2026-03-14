using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bonuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsPercent = table.Column<bool>(type: "bit", nullable: false),
                    AmountOrPercent = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    DateAdded = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bonuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deductions",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsPreTax = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deductions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTypes",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FederalTaxes",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(4,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FederalTaxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinancialInstitutions",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    RoutingNumber = table.Column<string>(type: "char(9)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialInstitutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FixedSchedules",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    WorkOnSunday = table.Column<bool>(type: "bit", nullable: false),
                    WorkOnMonday = table.Column<bool>(type: "bit", nullable: false),
                    WorkOnTuesday = table.Column<bool>(type: "bit", nullable: false),
                    WorkOnWednesday = table.Column<bool>(type: "bit", nullable: false),
                    WorkOnThursday = table.Column<bool>(type: "bit", nullable: false),
                    WorkOnFriday = table.Column<bool>(type: "bit", nullable: false),
                    WorkOnSaturday = table.Column<bool>(type: "bit", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixedSchedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceCompanies",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PayableBenefits",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IsInsurance = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayableBenefits", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "PaymentPeriodTypes",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPeriodTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeOffTypes",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IsAccruable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeOffTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkDays",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkDays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InsurancePlans",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceCompanyId = table.Column<byte>(type: "tinyint", nullable: false),
                    PayableBenefitId = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsurancePlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsurancePlans_InsuranceCompanies_InsuranceCompanyId",
                        column: x => x.InsuranceCompanyId,
                        principalTable: "InsuranceCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsurancePlans_PayableBenefits_PayableBenefitId",
                        column: x => x.PayableBenefitId,
                        principalTable: "PayableBenefits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BusinessLocations",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ZipCode = table.Column<string>(type: "char(5)", nullable: false),
                    StateId = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessLocations_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ZipCode = table.Column<string>(type: "char(5)", nullable: false),
                    StateId = table.Column<byte>(type: "tinyint", nullable: false),
                    Phone = table.Column<string>(type: "char(10)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocalTaxes",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateId = table.Column<byte>(type: "tinyint", nullable: false),
                    Municipality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsHeadTax = table.Column<bool>(type: "bit", nullable: false),
                    RateOrAmount = table.Column<decimal>(type: "decimal(9,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalTaxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocalTaxes_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StatesTaxes",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    StateId = table.Column<byte>(type: "tinyint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(4,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatesTaxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatesTaxes_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyInfo",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BusinessLocationId = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CompanyInfo_BusinessLocations_BusinessLocationId",
                        column: x => x.BusinessLocationId,
                        principalTable: "BusinessLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApprovedOvertimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    HoursAllowed = table.Column<byte>(type: "tinyint", nullable: false),
                    ApprovedOn = table.Column<DateOnly>(type: "date", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovedOvertimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApprovedOvertimes_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction); // Changed to NoAction to avoid cycles
                    table.ForeignKey(
                        name: "FK_ApprovedOvertimes_Employees_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction); // Changed to NoAction to avoid cycles
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Employees_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAccruedTimeOffs",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    TimeOffTypeId = table.Column<byte>(type: "tinyint", nullable: false),
                    AccruedHours = table.Column<short>(type: "smallint", nullable: false),
                    AccruedMinutes = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAccruedTimeOffs", x => new { x.EmployeeId, x.TimeOffTypeId });
                    table.ForeignKey(
                        name: "FK_EmployeeAccruedTimeOffs_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeAccruedTimeOffs_TimeOffTypes_TimeOffTypeId",
                        column: x => x.TimeOffTypeId,
                        principalTable: "TimeOffTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeBonuses",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    BonusId = table.Column<int>(type: "int", nullable: false),
                    WasPaid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeBonuses", x => new { x.EmployeeId, x.BonusId });
                    table.ForeignKey(
                        name: "FK_EmployeeBonuses_Bonuses_BonusId",
                        column: x => x.BonusId,
                        principalTable: "Bonuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeBonuses_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeContributableAccounts",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PayableBenefitId = table.Column<byte>(type: "tinyint", nullable: false),
                    EmployeeContribution = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    EmployeeContributionIsPercent = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeYearlyMaxAllowed = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    AccountNumberHash = table.Column<byte[]>(type: "binary(32)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeContributableAccounts", x => new { x.EmployeeId, x.PayableBenefitId });
                    table.ForeignKey(
                        name: "FK_EmployeeContributableAccounts_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeContributableAccounts_PayableBenefits_PayableBenefitId",
                        column: x => x.PayableBenefitId,
                        principalTable: "PayableBenefits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDeductions",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DeductionId = table.Column<byte>(type: "tinyint", nullable: false),
                    IsPercent = table.Column<bool>(type: "bit", nullable: false),
                    RateOrAmount = table.Column<decimal>(type: "decimal(10,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDeductions", x => new { x.EmployeeId, x.DeductionId });
                    table.ForeignKey(
                        name: "FK_EmployeeDeductions_Deductions_DeductionId",
                        column: x => x.DeductionId,
                        principalTable: "Deductions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeDeductions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeInsurancePlans",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    InsurancePlanId = table.Column<short>(type: "smallint", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    PolicyNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    MonthlyCharges = table.Column<decimal>(type: "decimal(7,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeInsurancePlans", x => new { x.EmployeeId, x.InsurancePlanId });
                    table.ForeignKey(
                        name: "FK_EmployeeInsurancePlans_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeInsurancePlans_InsurancePlans_InsurancePlanId",
                        column: x => x.InsurancePlanId,
                        principalTable: "InsurancePlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePayableBenefitStatuses",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PayableBenefitId = table.Column<byte>(type: "tinyint", nullable: false),
                    PayableBenefitStatusId = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePayableBenefitStatuses", x => new { x.EmployeeId, x.PayableBenefitId, x.PayableBenefitStatusId });
                    table.ForeignKey(
                        name: "FK_EmployeePayableBenefitStatuses_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeePayableBenefitStatuses_PayableBenefitsStatuses_PayableBenefitStatusId",
                        column: x => x.PayableBenefitStatusId,
                        principalTable: "PayableBenefitsStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeePayableBenefitStatuses_PayableBenefits_PayableBenefitId",
                        column: x => x.PayableBenefitId,
                        principalTable: "PayableBenefits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePictures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeePictures_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeShifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    WorkDayId = table.Column<short>(type: "smallint", nullable: false),
                    BeginTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    MinutesLate = table.Column<short>(type: "smallint", nullable: false),
                    MinutesLeftEarly = table.Column<short>(type: "smallint", nullable: false),
                    MissedShift = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeShifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeShifts_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeShifts_WorkDays_WorkDayId",
                        column: x => x.WorkDayId,
                        principalTable: "WorkDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTimeOffUses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    TimeOffTypeId = table.Column<byte>(type: "tinyint", nullable: false),
                    Motive = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WorkDayId = table.Column<short>(type: "smallint", nullable: false),
                    Hoursused = table.Column<byte>(type: "tinyint", nullable: false),
                    MinutesUsed = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTimeOffUses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeTimeOffUses_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTimeOffUses_TimeOffTypes_TimeOffTypeId",
                        column: x => x.TimeOffTypeId,
                        principalTable: "TimeOffTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTimeOffUses_WorkDays_WorkDayId",
                        column: x => x.WorkDayId,
                        principalTable: "WorkDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentPeriods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    LastDate = table.Column<DateOnly>(type: "date", nullable: true),
                    BusinessLocationId = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentPeriods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmploymentPeriods_BusinessLocations_BusinessLocationId",
                        column: x => x.BusinessLocationId,
                        principalTable: "BusinessLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmploymentPeriods_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction); // Changed to NoAction to avoid cycles
                });

            migrationBuilder.CreateTable(
                name: "FixedScheduleEmployees",
                columns: table => new
                {
                    FixedScheduleId = table.Column<byte>(type: "tinyint", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixedScheduleEmployees", x => new { x.FixedScheduleId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_FixedScheduleEmployees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FixedScheduleEmployees_FixedSchedules_FixedScheduleId",
                        column: x => x.FixedScheduleId,
                        principalTable: "FixedSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayrollInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    FederalTaxWithholdingRate = table.Column<double>(type: "float", nullable: false),
                    StateTaxWithholdingRate = table.Column<double>(type: "float", nullable: false),
                    SSNHash = table.Column<byte[]>(type: "binary(32)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayrollInfos_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Salaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    IsHourly = table.Column<bool>(type: "bit", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salaries_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "binary(32)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentBonuses",
                columns: table => new
                {
                    DepartmentId = table.Column<byte>(type: "tinyint", nullable: false),
                    BonusId = table.Column<int>(type: "int", nullable: false),
                    WasPaid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentBonuses", x => new { x.DepartmentId, x.BonusId });
                    table.ForeignKey(
                        name: "FK_DepartmentBonuses_Bonuses_BonusId",
                        column: x => x.BonusId,
                        principalTable: "Bonuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentBonuses_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsOvertimeExempt = table.Column<bool>(type: "bit", nullable: false),
                    IsFixedSchedule = table.Column<bool>(type: "bit", nullable: false),
                    IsFullTime = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeTypeId = table.Column<byte>(type: "tinyint", nullable: false),
                    PaymentPeriodTypeId = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobTitles_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobTitles_EmployeeTypes_EmployeeTypeId",
                        column: x => x.EmployeeTypeId,
                        principalTable: "EmployeeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobTitles_PaymentPeriodTypes_PaymentPeriodTypeId",
                        column: x => x.PaymentPeriodTypeId,
                        principalTable: "PaymentPeriodTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DirectDepositInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FinancialInstitutionId = table.Column<byte>(type: "tinyint", nullable: false),
                    PayrollInfoId = table.Column<int>(type: "int", nullable: false),
                    AccountNumberHash = table.Column<byte[]>(type: "binary(32)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectDepositInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DirectDepositInfos_FinancialInstitutions_FinancialInstitutionId",
                        column: x => x.FinancialInstitutionId,
                        principalTable: "FinancialInstitutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DirectDepositInfos_PayrollInfos_PayrollInfoId",
                        column: x => x.PayrollInfoId,
                        principalTable: "PayrollInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeJobTitle",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    JobTitleId = table.Column<short>(type: "smallint", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeJobTitle", x => new { x.EmployeeId, x.JobTitleId });
                    table.ForeignKey(
                        name: "FK_EmployeeJobTitle_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction); // Changed to NoAction to avoid cycles
                    table.ForeignKey(
                        name: "FK_EmployeeJobTitle_JobTitles_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobTitlePayableBenefits",
                columns: table => new
                {
                    JobTitleId = table.Column<short>(type: "smallint", nullable: false),
                    PayableBenefitId = table.Column<byte>(type: "tinyint", nullable: false),
                    EmployerContribution = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    EmployerContributionIsPercent = table.Column<bool>(type: "bit", nullable: false),
                    EmployerYearlyMaxAllowed = table.Column<decimal>(type: "decimal(7,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitlePayableBenefits", x => new { x.JobTitleId, x.PayableBenefitId });
                    table.ForeignKey(
                        name: "FK_JobTitlePayableBenefits_JobTitles_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobTitlePayableBenefits_PayableBenefits_PayableBenefitId",
                        column: x => x.PayableBenefitId,
                        principalTable: "PayableBenefits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobTitleTimeOffTypes",
                columns: table => new
                {
                    JobTitleId = table.Column<short>(type: "smallint", nullable: false),
                    TimeOffTypeId = table.Column<byte>(type: "tinyint", nullable: false),
                    WorkHoursToOneHourOff = table.Column<byte>(type: "tinyint", nullable: false),
                    PayOnTermination = table.Column<bool>(type: "bit", nullable: false),
                    PayOnUse = table.Column<bool>(type: "bit", nullable: false),
                    MaxHours = table.Column<short>(type: "smallint", nullable: false),
                    MaxYearlyCarryover = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitleTimeOffTypes", x => new { x.JobTitleId, x.TimeOffTypeId });
                    table.ForeignKey(
                        name: "FK_JobTitleTimeOffTypes_JobTitles_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobTitleTimeOffTypes_TimeOffTypes_TimeOffTypeId",
                        column: x => x.TimeOffTypeId,
                        principalTable: "TimeOffTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApprovedOvertimes_EmployeeId",
                table: "ApprovedOvertimes",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ApprovedOvertimes_ManagerId",
                table: "ApprovedOvertimes",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessLocations_StateId",
                table: "BusinessLocations",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyInfo_BusinessLocationId",
                table: "CompanyInfo",
                column: "BusinessLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentBonuses_BonusId",
                table: "DepartmentBonuses",
                column: "BonusId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerId",
                table: "Departments",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectDepositInfos_FinancialInstitutionId",
                table: "DirectDepositInfos",
                column: "FinancialInstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectDepositInfos_PayrollInfoId",
                table: "DirectDepositInfos",
                column: "PayrollInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAccruedTimeOffs_TimeOffTypeId",
                table: "EmployeeAccruedTimeOffs",
                column: "TimeOffTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBonuses_BonusId",
                table: "EmployeeBonuses",
                column: "BonusId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeContributableAccounts_PayableBenefitId",
                table: "EmployeeContributableAccounts",
                column: "PayableBenefitId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDeductions_DeductionId",
                table: "EmployeeDeductions",
                column: "DeductionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInsurancePlans_InsurancePlanId",
                table: "EmployeeInsurancePlans",
                column: "InsurancePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeJobTitle_JobTitleId",
                table: "EmployeeJobTitle",
                column: "JobTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePayableBenefitStatuses_PayableBenefitId",
                table: "EmployeePayableBenefitStatuses",
                column: "PayableBenefitId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePayableBenefitStatuses_PayableBenefitStatusId",
                table: "EmployeePayableBenefitStatuses",
                column: "PayableBenefitStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePictures_EmployeeId",
                table: "EmployeePictures",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_StateId",
                table: "Employees",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeShifts_EmployeeId",
                table: "EmployeeShifts",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeShifts_WorkDayId",
                table: "EmployeeShifts",
                column: "WorkDayId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTimeOffUses_EmployeeId",
                table: "EmployeeTimeOffUses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTimeOffUses_TimeOffTypeId",
                table: "EmployeeTimeOffUses",
                column: "TimeOffTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTimeOffUses_WorkDayId",
                table: "EmployeeTimeOffUses",
                column: "WorkDayId");

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentPeriods_BusinessLocationId",
                table: "EmploymentPeriods",
                column: "BusinessLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentPeriods_EmployeeId",
                table: "EmploymentPeriods",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_FixedScheduleEmployees_EmployeeId",
                table: "FixedScheduleEmployees",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePlans_InsuranceCompanyId",
                table: "InsurancePlans",
                column: "InsuranceCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePlans_PayableBenefitId",
                table: "InsurancePlans",
                column: "PayableBenefitId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitlePayableBenefits_PayableBenefitId",
                table: "JobTitlePayableBenefits",
                column: "PayableBenefitId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_DepartmentId",
                table: "JobTitles",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_EmployeeTypeId",
                table: "JobTitles",
                column: "EmployeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_PaymentPeriodTypeId",
                table: "JobTitles",
                column: "PaymentPeriodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitleTimeOffTypes_TimeOffTypeId",
                table: "JobTitleTimeOffTypes",
                column: "TimeOffTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalTaxes_StateId",
                table: "LocalTaxes",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_PayrollInfos_EmployeeId",
                table: "PayrollInfos",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_EmployeeId",
                table: "Salaries",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_StatesTaxes_StateId",
                table: "StatesTaxes",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmployeeId",
                table: "Users",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApprovedOvertimes");

            migrationBuilder.DropTable(
                name: "CompanyInfo");

            migrationBuilder.DropTable(
                name: "DepartmentBonuses");

            migrationBuilder.DropTable(
                name: "DirectDepositInfos");

            migrationBuilder.DropTable(
                name: "EmployeeAccruedTimeOffs");

            migrationBuilder.DropTable(
                name: "EmployeeBonuses");

            migrationBuilder.DropTable(
                name: "EmployeeContributableAccounts");

            migrationBuilder.DropTable(
                name: "EmployeeDeductions");

            migrationBuilder.DropTable(
                name: "EmployeeInsurancePlans");

            migrationBuilder.DropTable(
                name: "EmployeeJobTitle");

            migrationBuilder.DropTable(
                name: "EmployeePayableBenefitStatuses");

            migrationBuilder.DropTable(
                name: "EmployeePictures");

            migrationBuilder.DropTable(
                name: "EmployeeShifts");

            migrationBuilder.DropTable(
                name: "EmployeeTimeOffUses");

            migrationBuilder.DropTable(
                name: "EmploymentPeriods");

            migrationBuilder.DropTable(
                name: "FederalTaxes");

            migrationBuilder.DropTable(
                name: "FixedScheduleEmployees");

            migrationBuilder.DropTable(
                name: "JobTitlePayableBenefits");

            migrationBuilder.DropTable(
                name: "JobTitleTimeOffTypes");

            migrationBuilder.DropTable(
                name: "LocalTaxes");

            migrationBuilder.DropTable(
                name: "Salaries");

            migrationBuilder.DropTable(
                name: "StatesTaxes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "FinancialInstitutions");

            migrationBuilder.DropTable(
                name: "PayrollInfos");

            migrationBuilder.DropTable(
                name: "Bonuses");

            migrationBuilder.DropTable(
                name: "Deductions");

            migrationBuilder.DropTable(
                name: "InsurancePlans");

            migrationBuilder.DropTable(
                name: "PayableBenefitsStatuses");

            migrationBuilder.DropTable(
                name: "WorkDays");

            migrationBuilder.DropTable(
                name: "BusinessLocations");

            migrationBuilder.DropTable(
                name: "FixedSchedules");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "TimeOffTypes");

            migrationBuilder.DropTable(
                name: "InsuranceCompanies");

            migrationBuilder.DropTable(
                name: "PayableBenefits");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "EmployeeTypes");

            migrationBuilder.DropTable(
                name: "PaymentPeriodTypes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
