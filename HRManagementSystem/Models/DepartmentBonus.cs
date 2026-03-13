namespace HRManagementSystem.Models
{
    class DepartmentBonus
    {
        public Department? Employee { get; set; }
        public byte DepartmentId { get; set; }
        public Bonus? Bonus { get; set; }
        public uint BonusId { get; set; }
        public bool WasPaid { get; set; }
    }
}
