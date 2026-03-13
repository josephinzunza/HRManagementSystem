namespace HRManagementSystem.Models
{
    public class JobTitle
    {
        public ushort Id { get; set; }
        public Department? Department { get; set; }
        public byte DepartmentId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsOvertimeExempt { get; set; }
        public bool IsFixedSchedule { get; set; }
        public bool IsFullTime { get; set; }
        public EmployeeType? EmployeeType { get; set; }
        public byte EmployeeTypeId { get; set; }
        public PaymentPeriodType? PaymentPeriodType { get; set; }
        public byte PaymentPeriodTypeId { get; set; }
    }
}
