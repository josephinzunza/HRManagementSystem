namespace HRManagementSystem.Models
{
    public class EmployeeAccruedTimeOff
    {
        public Employee? Employee { get; set; }
        public uint EmployeeId { get; set; }
        public TimeOffType? TimeOffType { get; set; }
        public byte TimeOffTypeId { get; set; }
        public ushort AccruedHours { get; set; }
        public byte AccruedMinutes { get; set; }
    }
}
