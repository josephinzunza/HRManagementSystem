namespace HRManagementSystem.Models
{
    public class EmployeeDeclinedPayableBenefit
    {
        public Employee? Employee { get; set; }
        public int EmployeeId { get; set; }
        public PayableBenefit? PayableBenefit { get; set; }
        public byte PayableBenefitId { get; set; }
    }
}
