namespace HRManagementSystem.Models
{
    public class EmployeeContributableAccount
    {
        public Employee? Employee { get; set; }
        public uint EmployeeId { get; set; }
        public PayableBenefit? PayableBenefit { get; set; }
        public byte PayableBenefitId { get; set; }
        public decimal EmployeeContribution { get; set; }
        public bool EmployeeContributionIsPercent { get; set; }
        public decimal EmployeeYearlyMaxAllowed { get; set; }
        public byte[] AccountNumberHash { get; set; } = [];
    }
}
