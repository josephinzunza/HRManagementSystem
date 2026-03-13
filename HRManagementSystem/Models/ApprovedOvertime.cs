namespace HRManagementSystem.Models
{
    public class ApprovedOvertime
    {
        public uint Id { get; set; }
        public Employee? Employee { get; set; }
        public uint EmployeeId { get; set; }
        public Employee? Manager { get; set; }
        public uint ManagerId { get; set; }
        public byte HoursAllowed { get; set; }
    }
}
