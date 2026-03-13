namespace HRManagementSystem.Models
{
    public class TimeOffType
    {
        public byte Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsAccruable { get; set; }
    }
}
