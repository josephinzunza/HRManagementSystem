
namespace HRManagementSystem.Models
{
    public class EmployeeJobTitle
    {
        public Employee? Employee { get; set; }
        public uint EmployeeId { get; set; }
        public JobTitle? JobTitle { get; set; }
        public ushort JobTitleId { get; set; }
        public DateOnly StartDate { get; set; }
    }
}
