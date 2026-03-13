namespace HRManagementSystem.Models
{
    public class JobTitleTimeOffType
    {
        public JobTitle? JobTitle { get; set; }
        public ushort JobtitleId { get; set; }

        public TimeOffType? TimeOff { get; set; }
        public byte TimeOffTypeId { get; set; }
        public byte WorkHoursToOneHourOff { get; set; }
        public bool PayOnTermination { get; set; }
        public bool PayOnUse { get; set; }
        public ushort MaxHours { get; set; }
        public ushort MaxYearlyCarryover { get; set; }

    }
}
