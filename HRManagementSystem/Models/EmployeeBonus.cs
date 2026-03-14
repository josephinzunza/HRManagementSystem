namespace HRManagementSystem.Models
{
    public class EmployeeBonus
    {
        public Employee? Employee { get; set; }
        public int EmployeeId { get; set; }
        public Bonus? Bonus { get; set; }
        public int BonusId { get; set; }
        public bool WasPaid { get; set; }
    }
}
