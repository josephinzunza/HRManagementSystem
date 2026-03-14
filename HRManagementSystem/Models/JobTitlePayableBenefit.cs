namespace HRManagementSystem.Models
{
    public class JobTitlePayableBenefit
    {
        public JobTitle? JobTitle { get; set; }
        public short JobTitleId { get; set; }
        public PayableBenefit? PayableBenefit { get; set; }
        public byte PayableBenefitId { get; set; }
        public decimal EmployerContribution { get; set; }
        public bool EmployerContributionIsPercent { get; set; }
        public decimal EmployerYearlyMaxAllowed { get; set; }
    }
}
