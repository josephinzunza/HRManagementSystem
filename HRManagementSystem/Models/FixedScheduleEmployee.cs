namespace HRManagementSystem.Models
{
    public class FixedScheduleEmployee
    {
        public FixedSchedule? FixedSchedule { get; set; }
        public byte FixedScheduleId { get; set; }
        public Employee? Employee { get; set; }
        public uint EmployeeId { get; set; }
        
    }
}
