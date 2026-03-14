namespace HRManagementSystem.Models
{
    public class ApprovedOvertime
    {
        public int Id { get; set; }
        public Employee? Employee { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Manager { get; set; }
        public int ManagerId { get; set; }
        public byte HoursAllowed { get; set; }
        public DateOnly ApprovedOn { get; set; }
        public DateOnly StartDate { get; set; }
    }
}
