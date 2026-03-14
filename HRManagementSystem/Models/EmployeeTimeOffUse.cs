namespace HRManagementSystem.Models
{
    public class EmployeeTimeOffUse
    {
        public int Id { get; set; }
        public Employee? Employee { get; set; }
        public int EmployeeId { get; set; }
        public TimeOffType? TimeOffType { get; set; }
        public byte TimeOffTypeId { get; set; }
        public WorkDay? WorkDay { get; set; }
        public string Motive { get; set; } = string.Empty;
        public short WorkDayId { get; set; }
        public byte Hoursused { get; set; }
        public byte MinutesUsed { get; set; }
    }
}
