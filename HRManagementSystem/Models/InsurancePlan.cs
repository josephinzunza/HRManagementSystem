namespace HRManagementSystem.Models
{
    public class InsurancePlan
    {
        public ushort Id { get; set; }
        public InsuranceCompany? InsuranceCompany { get; set; }
        public byte InsuranceCompanyId { get; set; }
        public PayableBenefit? PayableBenefit { get; set; }
        public byte PayableBenefitId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

    }
}
