namespace HRManagementSystem.Models
{
    public class EmploymentPeriod
    {
        public uint Id { get; set; }
        public Employee? Employee { get; set; }
        public uint EmployeeId { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly? LastDate { get; set; }
        public BusinessLocation? BusinessLocation { get; set; }
        public ushort BusinessLocationId { get; set; }
    }
}
