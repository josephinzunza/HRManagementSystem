namespace HRManagementSystem.Models
{
    public class EmployeeInsurancePlan
    {
        public int Id { get; set; }
        public Employee? Employee { get; set; }
        public int EmployeeId { get; set; }
        public InsurancePlan? InsurancePlan { get; set; }
        public short InsurancePlanId { get; set; }
        public string PolicyNumber { get; set; } = string.Empty;
        public decimal MonthlyCharges { get; set; }
    }
}
