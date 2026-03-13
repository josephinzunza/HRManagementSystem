
namespace HRManagementSystem.Models
{
    public class FixedSchedule
    {
        public byte Id { get; set; }
        public bool WorkOnSunday { get; set; }
        public bool WorkOnMonday { get; set; }
        public bool WorkOnTuesday { get; set; }
        public bool WorkOnWednesday { get; set; }
        public bool WorkOnThursday { get; set; }
        public bool WorkOnFriday { get; set; }
        public bool WorkOnSaturday { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
    }
}
