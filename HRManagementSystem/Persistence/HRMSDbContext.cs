using HRManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace HRManagementSystem
{
    public class HRMSDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HRMSDatabase"].ConnectionString;
            
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Indicate that the CompanyInfo table has no primary key
            modelBuilder.Entity<CompanyInfo>().HasNoKey();

            // Configure the composite primary key for the DepartmentBonuses junction table
            modelBuilder.Entity<DepartmentBonus>().HasKey(db => new { db.DepartmentId, db.BonusId });

            // Configure the composite primary key for the EmployeeAccruedTimeOffs junction table
            modelBuilder.Entity<EmployeeAccruedTimeOff>().HasKey(eato => new { eato.EmployeeId, eato.TimeOffTypeId });

            // Configure the composite primary key for the EmployeeBonuses junction table
            modelBuilder.Entity<EmployeeBonus>().HasKey(eb => new { eb.EmployeeId, eb.BonusId });

            // Configure the composite primary key for the EmployeeContributableAccounts junction table
            modelBuilder.Entity<EmployeeContributableAccount>().HasKey(eca => new { eca.EmployeeId, eca.PayableBenefitId });

            // Configure the composite primary key for the EmployeeDeductions junction table
            modelBuilder.Entity<EmployeeDeduction>().HasKey(ed => new { ed.EmployeeId, ed.DeductionId });

            // Configure the composite primary key for the EmployeeInsurancePlans junction table
            modelBuilder.Entity<EmployeeInsurancePlan>().HasKey(eip => new { eip.EmployeeId, eip.InsurancePlanId });

            // Configure the composite primary key for the EmployeeJobTitles junction table
            modelBuilder.Entity<EmployeeJobTitle>().HasKey(ejt => new { ejt.EmployeeId, ejt.JobTitleId });

            // Configure the composite primary key for the EmployeePayableBenefitStatuses junction table
            modelBuilder.Entity<EmployeeDeclinedPayableBenefit>().HasKey(epbs => new { epbs.EmployeeId, epbs.PayableBenefitId });

            // Configure the composite primary key for the FixedScheduleEmployees junction table
            modelBuilder.Entity<FixedScheduleEmployee>().HasKey(fse => new { fse.FixedScheduleId, fse.EmployeeId });

            // Configure the composite primary key for the JobTitlePayableBenefits junction table
            modelBuilder.Entity<JobTitlePayableBenefit>().HasKey(jtpb => new { jtpb.JobTitleId, jtpb.PayableBenefitId });

            // Configure the composite primary key for the JobTitleTimeOffTypes junction table
            modelBuilder.Entity<JobTitleTimeOffType>().HasKey(jttot => new { jttot.JobTitleId, jttot.TimeOffTypeId });

            // Set decimal precision on Bonuses decimal properties
            // Set varchar size on Bonuses string properties
            modelBuilder.Entity<Bonus>(entity => {
                entity.Property(b => b.AmountOrPercent).HasColumnType("decimal(9,2)");
                entity.Property(b => b.Description).HasMaxLength(100);
            });

            // Set varchar size on BusinessLocations string properties
            modelBuilder.Entity<BusinessLocation>(entity => {
                entity.Property(bl => bl.Address).HasMaxLength(50);
                entity.Property(bl => bl.City).HasMaxLength(50);
                entity.Property(bl => bl.ZipCode).HasColumnType("char(5)");

            });

            // Set varchar size on CompanyInfos string properties
            modelBuilder.Entity<CompanyInfo>(entity =>
                    entity.Property(ci => ci.Name).HasMaxLength(100));

            // Set varchar size on Deductions string properties
            modelBuilder.Entity<Deduction>(entity =>
                    entity.Property(d => d.Description).HasMaxLength(100));

            // Set varchar size on Departments string properties
            modelBuilder.Entity<Department>(entity =>
                    entity.Property(d => d.Name).HasMaxLength(30));

            // Set varchar size on DirectDepositInfos binary properties
            modelBuilder.Entity<DirectDepositInfo>(entity =>
                entity.Property(ddi => ddi.AccountNumberHash).HasColumnType("binary(32)"));

            // Set varchar size on BusinessLocations string properties
            modelBuilder.Entity<Employee>(entity => {
                entity.Property(e => e.FirstName).HasMaxLength(128);
                entity.Property(e => e.LastName).HasMaxLength(128);
                entity.Property(e => e.Address).HasMaxLength(50);
                entity.Property(e => e.City).HasMaxLength(50);
                entity.Property(e => e.ZipCode).HasColumnType("char(5)");
                entity.Property(e => e.PhoneNumber).HasColumnType("char(10)");
                entity.Property(e => e.Email).HasMaxLength(128);
                entity.Property(e => e.Gender).HasMaxLength(30);
            });

            // Set decimal precision on EmployeeContributableAccounts decimal properties
            // Set varchar size on EmployeeContributableAccounts binary properties
            modelBuilder.Entity<EmployeeContributableAccount>(entity => {
                entity.Property(eca => eca.EmployeeContribution).HasColumnType("decimal(7,2)");
                entity.Property(eca => eca.EmployeeYearlyMaxAllowed).HasColumnType("decimal(7,2)");
                entity.Property(eca => eca.AccountNumberHash).HasColumnType("binary(32)");
            });

            // Set decimal precision on EmployeeDeductions decimal properties
            modelBuilder.Entity<EmployeeDeduction>(entity =>
                    entity.Property(ed => ed.RateOrAmount).HasColumnType("decimal(10,3)"));

            // Set decimal precision on EmployeeInsurancePlans decimal properties
            modelBuilder.Entity<EmployeeInsurancePlan>(entity => {
                entity.Property(eip => eip.MonthlyCharges).HasColumnType("decimal(7,2)");
                entity.Property(eip => eip.PolicyNumber).HasMaxLength(15);
            });

            // Set varchar size on EmployeeTimeOffUses string properties
            modelBuilder.Entity<EmployeeTimeOffUse>(entity =>
                    entity.Property(etou => etou.Motive).HasMaxLength(50));

            // Set varchar size on EmployeeTypes string properties
            modelBuilder.Entity<EmployeeType>(entity =>
                    entity.Property(et => et.Name).HasMaxLength(20));

            // Set decimal precision on FederalTaxes decimal properties
            // Set varchar size on FederalTaxes string properties
            modelBuilder.Entity<FederalTax>(entity => {
                entity.Property(ft => ft.Rate).HasColumnType("decimal(4,2)");
                entity.Property(ft => ft.Name).HasMaxLength(20);
            });

            // Set varchar size on FederalTaxes string properties
            modelBuilder.Entity<FinancialInstitution>(entity => {
                entity.Property(fi => fi.Name).HasMaxLength(128);
                entity.Property(fi => fi.RoutingNumber).HasColumnType("char(9)");
            });

            // Set decimal precision on JobTitlePayableBenefits decimal properties
            modelBuilder.Entity<JobTitlePayableBenefit>(entity => {
                entity.Property(jtpb => jtpb.EmployerContribution).HasColumnType("decimal(7,2)");
                entity.Property(jtpb => jtpb.EmployerYearlyMaxAllowed).HasColumnType("decimal(7,2)");
            });

            // Set varchar size on EmployeeTimeOffUses string properties
            modelBuilder.Entity<InsuranceCompany>(entity =>
                    entity.Property(ic => ic.Name).HasMaxLength(128));

            // Set varchar size on InsurancePlans string properties
            modelBuilder.Entity<InsurancePlan>(entity => {
                entity.Property(ip => ip.Name).HasMaxLength(128);
                entity.Property(ip => ip.Description).HasMaxLength(256);
            });

            // Set varchar size on JobTitles string properties
            modelBuilder.Entity<JobTitle>(entity =>
                entity.Property(jt => jt.Name).HasMaxLength(50));

            // Set decimal precision on LocalTaxes decimal properties
            // Set varchar size on LocalTaxes string properties
            modelBuilder.Entity<LocalTax>(entity => {
                entity.Property(lt => lt.RateOrAmount).HasColumnType("decimal(9,2)");
                entity.Property(lt => lt.Municipality).HasMaxLength(50);
                entity.Property(lt => lt.Description).HasMaxLength(100);
            });

            // Set varchar size on PayableBenefits string properties
            modelBuilder.Entity<PayableBenefit>(entity =>
                    entity.Property(pb => pb.Name).HasMaxLength(50));

            // Set varchar size on PaymentPeriodTypes string properties
            modelBuilder.Entity<PaymentPeriodType>(entity =>
                    entity.Property(ppt => ppt.Name).HasMaxLength(20));

            // Set varchar size on PayrollInfos binary properties
            modelBuilder.Entity<PayrollInfo>(entity =>
                entity.Property(s => s.SSNHash).HasColumnType("binary(32)"));

            // Set decimal precision on Salaries decimal properties
            // Set varchar size on Salaries string properties
            modelBuilder.Entity<Salary>(entity => {
                entity.Property(s => s.Amount).HasColumnType("decimal(9,2)");
                entity.Property(s => s.Details).HasMaxLength(50);
            });

            // Set varchar size on States string properties
            modelBuilder.Entity<State>(entity =>
                    entity.Property(s => s.Name).HasMaxLength(15));

            // Set decimal precision on StateTaxes decimal properties
            // Set varchar size on StateTaxes string properties
            modelBuilder.Entity<StateTax>(entity => {
                entity.Property(st => st.Rate).HasColumnType("decimal(4,2)");
                entity.Property(st => st.Description).HasMaxLength(50);
            });

            // Set varchar size on TimeOffTypes string properties
            modelBuilder.Entity<TimeOffType>(entity =>
                    entity.Property(tot => tot.Name).HasMaxLength(30));

            // Set varchar size on Users binary properties
            // Set varchar size on Users string properties
            modelBuilder.Entity<User>(entity => {
                entity.Property(u => u.PasswordHash).HasColumnType("binary(32)");
                entity.Property(u => u.UserName).HasMaxLength(32);
            });
        }
        public DbSet<ApprovedOvertime> ApprovedOvertimes { get; set; }
        public DbSet<Bonus> Bonuses { get; set; }
        public DbSet<BusinessLocation> BusinessLocations { get; set; }
        public DbSet<CompanyInfo> CompanyInfo { get; set; }
        public DbSet<Deduction> Deductions { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentBonus> DepartmentBonuses { get; set; }
        public DbSet<DirectDepositInfo> DirectDepositInfos { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAccruedTimeOff> EmployeeAccruedTimeOffs { get; set; }
        public DbSet<EmployeeBonus> EmployeeBonuses { get; set; }
        public DbSet<EmployeeContributableAccount> EmployeeContributableAccounts { get; set; }
        public DbSet<EmployeeDeduction> EmployeeDeductions { get; set; }
        public DbSet<EmployeeInsurancePlan> EmployeeInsurancePlans { get; set; }
        public DbSet<EmployeeJobTitle> EmployeeJobTitle { get; set; }
        public DbSet<EmployeeDeclinedPayableBenefit> EmployeeDeclinedPayableBenefits { get; set; }
        public DbSet<EmployeePicture> EmployeePictures { get; set; }
        public DbSet<EmployeeShift> EmployeeShifts { get; set; }
        public DbSet<EmployeeTimeOffUse> EmployeeTimeOffUses { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<EmploymentPeriod> EmploymentPeriods { get; set; }
        public DbSet<FederalTax> FederalTaxes { get; set; }
        public DbSet<FinancialInstitution> FinancialInstitutions { get; set; }
        public DbSet<FixedSchedule> FixedSchedules { get; set; }
        public DbSet<FixedScheduleEmployee> FixedScheduleEmployees { get; set; }
        public DbSet<InsuranceCompany> InsuranceCompanies { get; set; }
        public DbSet<InsurancePlan> InsurancePlans { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<JobTitlePayableBenefit> JobTitlePayableBenefits { get; set; }
        public DbSet<JobTitleTimeOffType> JobTitleTimeOffTypes { get; set; }
        public DbSet<LocalTax> LocalTaxes { get; set; }
        public DbSet<PayableBenefit> PayableBenefits { get; set; }
        public DbSet<PaymentPeriodType> PaymentPeriodTypes { get; set; }
        public DbSet<PayrollInfo> PayrollInfos { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<StateTax> StatesTaxes { get; set; }
        public DbSet<TimeOffType> TimeOffTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkDay> WorkDays { get; set; }
    }
}
