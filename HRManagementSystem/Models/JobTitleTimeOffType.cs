namespace HRManagementSystem.Models
{
    public class JobTitleTimeOffType
    {
        public JobTitle? JobTitle { get; set; }
        public short JobTitleId { get; set; }

        public TimeOffType? TimeOff { get; set; }
        public byte TimeOffTypeId { get; set; }
        public byte WorkHoursToOneHourOff { get; set; }
        public bool PayOnTermination { get; set; }
        public bool PayOnUse { get; set; }
        public short MaxHours { get; set; }
        public short MaxYearlyCarryover { get; set; }

    }
}
