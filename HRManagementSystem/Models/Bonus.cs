namespace HRManagementSystem.Models
{
    public class Bonus
    {
        public uint Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool IsPercent { get; set; }
        public decimal AmountOrPercent { get; set; }
        public DateOnly DateAdded { get; set; }
    }
}
