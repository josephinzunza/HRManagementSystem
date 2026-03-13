namespace HRManagementSystem.Models
{
    public class Deduction
    {
        public byte Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool IsPreTax { get; set; }
    }
}
