namespace HRManagementSystem.Models
{
    public class PayrollInfo
    {
        public int Id { get; set; }
        public Employee? Employee { get; set; }
        public int EmployeeId { get; set; }
        public double FederalTaxWithholdingRate { get; set; }
        public double StateTaxWithholdingRate { get; set; }
        public byte[] SSNHash { get; set; } = [];
    }
}
