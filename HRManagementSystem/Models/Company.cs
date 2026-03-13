namespace HRManagementSystem.Models
{
    public class Company
    {
        public string Name { get; set; } = string.Empty;
        public BusinessLocation? BusinessLocation { get; set; }
        public ushort BusinessLocationId { get; set; }
    }
}
