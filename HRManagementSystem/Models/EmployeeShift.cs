namespace HRManagementSystem.Models
{
    public class EmployeeShift
    {
        public int Id { get; set; }
        public Employee? Employee { get; set; }
        public int EmployeeId { get; set; }
        public WorkDay? WorkDay { get; set; }
        public short WorkDayId { get; set; }
        public TimeOnly BeginTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public short MinutesLate { get; set; }
        public short MinutesLeftEarly { get; set; }
        public bool MissedShift { get; set; }
    }
}
