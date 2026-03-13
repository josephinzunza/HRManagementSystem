namespace HRManagementSystem.Models
{
    public class DirectDepositInfo
    {
        public uint Id { get; set; }
        public byte[] AccountNumberHash { get; set; } = [];
        public FinancialInstitution? FinancialInstitution { get; set; }
        public byte FinancialInstitutionId { get; set; }
        public PayrollInfo? PayrollInfo { get; set; }
        public uint PayrollInfoId { get; set; }
    }
}
