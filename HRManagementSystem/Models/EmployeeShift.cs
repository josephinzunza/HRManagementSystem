namespace HRManagementSystem.Models
{
    public class EmployeeShift
    {
        public uint Id { get; set; }
        public Employee? Employee { get; set; }
        public uint EmployeeId { get; set; }
        public WorkDay? WorkDay { get; set; }
        public ushort WorkDayId { get; set; }
        public TimeOnly BeginTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public ushort MinutesLate { get; set; }
        public ushort MinutesLeftEarly { get; set; }
        public bool MissedShift { get; set; }
    }
}
