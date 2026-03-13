namespace HRManagementSystem.Models
{
    public class StateTax
    {
        public byte Id { get; set; }
        public State? State { get; set; }
        public byte StateId { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Rate { get; set; }
    }
}
