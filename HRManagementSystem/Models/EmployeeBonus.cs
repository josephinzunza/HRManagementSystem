namespace HRManagementSystem.Models
{
    public class EmployeeBonus
    {
        public Employee? Employee { get; set; }
        public uint EmployeeId { get; set; }
        public Bonus? Bonus { get; set; }
        public uint BonusId { get; set; }
        public bool WasPaid { get; set; }
    }
}
