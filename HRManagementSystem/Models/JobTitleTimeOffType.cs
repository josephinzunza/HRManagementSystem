namespace HRManagementSystem.Models
{
    public class JobTitleTimeOffType
    {
        public JobTitle? JobTitle { get; set; }
        public short JobTitleId { get; set; }

        public TimeOffType? TimeOff { get; set; }
        public byte TimeOffTypeId { get; set; }
        public bool IsAccruable { get; set; }
        public short WorkHoursToOneHourOff { get; set; }
        public bool PayOnTermination { get; set; }
        public bool PayOnUse { get; set; }
        public short MaxHours { get; set; }
        public short AllowedYearlyCarryoverHours { get; set; }
    }
}
