
namespace HRManagementSystem.Models
{
    public class EmployeeJobTitle
    {
        public Employee? Employee { get; set; }
        public int EmployeeId { get; set; }
        public JobTitle? JobTitle { get; set; }
        public short JobTitleId { get; set; }
        public DateOnly StartDate { get; set; }
    }
}
