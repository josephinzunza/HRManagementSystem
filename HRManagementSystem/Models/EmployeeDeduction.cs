
namespace HRManagementSystem.Models
{
    public class EmployeeDeduction
    {
        public Employee? Employee { get; set; }
        public uint EmployeeId { get; set; }
        public Deduction? Deduction { get; set; }
        public byte DeductionId { get; set; }
        public bool IsPercent { get; set; }
        public decimal RateOrAmount { get; set; }
    }
}
