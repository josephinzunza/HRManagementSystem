namespace HRManagementSystem.Models
{
    public class Salary
    {
        public uint Id { get; set; }
        public Employee? Employee { get; set; }
        public uint EmployeeId { get; set; }
        public bool IsHourly { get; set; }
        public decimal Amount { get; set; }
        public DateOnly StartDate { get; set; }
        public string Details { get; set; } = string.Empty;
    }
}
