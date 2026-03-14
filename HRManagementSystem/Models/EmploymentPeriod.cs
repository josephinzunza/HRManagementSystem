namespace HRManagementSystem.Models
{
    public class EmploymentPeriod
    {
        public int Id { get; set; }
        public Employee? Employee { get; set; }
        public int EmployeeId { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly? LastDate { get; set; }
        public BusinessLocation? BusinessLocation { get; set; }
        public short BusinessLocationId { get; set; }
    }
}
