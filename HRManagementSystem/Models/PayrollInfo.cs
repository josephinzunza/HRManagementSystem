namespace HRManagementSystem.Models
{
    public class PayrollInfo
    {
        public uint Id { get; set; }
        public uint EmployeeId { get; set; }
        public double FederalTaxWithholdingRate { get; set; }
        public double StateTaxWithholdingRate { get; set; }
        public byte[] SSNHash { get; set; } = [];
    }
}
