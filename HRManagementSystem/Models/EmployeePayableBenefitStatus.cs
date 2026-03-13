namespace HRManagementSystem.Models
{
    public class EmployeePayableBenefitStatus
    {
        public Employee? Employee { get; set; }
        public uint EmployeeId { get; set; }
        public PayableBenefit? PayableBenefit { get; set; }
        public byte PayableBenefitId { get; set; }
        public PayableBenefitStatus? PayableBenefitStatus { get; set; }
        public byte PayableBenefitStatusId { get; set; }
    }
}
