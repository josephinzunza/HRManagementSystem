namespace HRManagementSystem.Models
{
    public class Salary
    {
        public int Id { get; set; }
        public Employee? Employee { get; set; }
        public int EmployeeId { get; set; }
        public bool IsHourly { get; set; }
        public decimal Amount { get; set; }
        public DateOnly StartDate { get; set; }
        public string Details { get; set; } = string.Empty;
    }
}
