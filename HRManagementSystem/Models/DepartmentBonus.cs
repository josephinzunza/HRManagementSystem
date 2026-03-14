namespace HRManagementSystem.Models
{
    public class DepartmentBonus
    {
        public Department? Department { get; set; }
        public byte DepartmentId { get; set; }
        public Bonus? Bonus { get; set; }
        public int BonusId { get; set; }
        public bool WasPaid { get; set; }
    }
}
