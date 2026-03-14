namespace HRManagementSystem.Models
{
    public class DirectDepositInfo
    {
        public int Id { get; set; }
        public FinancialInstitution? FinancialInstitution { get; set; }
        public byte FinancialInstitutionId { get; set; }
        public PayrollInfo? PayrollInfo { get; set; }
        public int PayrollInfoId { get; set; }
        public byte[] AccountNumberHash { get; set; } = [];
    }
}
