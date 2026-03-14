namespace HRManagementSystem.Models
{
    public class LocalTax
    {
        public short Id { get; set; }
        public State? State { get; set; }
        public byte StateId { get; set; }
        public string Municipality { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsHeadTax { get; set; }
        public decimal RateOrAmount { get; set; }
    }
}
