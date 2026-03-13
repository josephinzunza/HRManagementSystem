namespace HRManagementSystem.Models
{
    public class EmployeeTimeOffUse
    {
        public uint Id { get; set; }
        public Employee? Employee { get; set; }
        public uint EmployeeId { get; set; }
        public TimeOffType? TimeOffType { get; set; }
        public byte TimeOffTypeId { get; set; }
        public WorkDay? WorkDay { get; set; }
        public ushort WorkDayId { get; set; }
        public byte Hoursused { get; set; }
        public byte MinutesUsed { get; set; }
    }
}
