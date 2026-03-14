namespace HRManagementSystem.Models
{
    public class EmployeeAccruedTimeOff
    {
        public Employee? Employee { get; set; }
        public int EmployeeId { get; set; }
        public TimeOffType? TimeOffType { get; set; }
        public byte TimeOffTypeId { get; set; }
        public short AccruedHours { get; set; }
        public byte AccruedMinutes { get; set; }
    }
}
