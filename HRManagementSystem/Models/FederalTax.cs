namespace HRManagementSystem.Models
{
    public class FederalTax
    {
        public byte Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Rate { get; set; }
    }
}
