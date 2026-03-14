namespace HRManagementSystem.Models
{
    public class CompanyInfo
    {
        public string Name { get; set; } = string.Empty;
        public BusinessLocation? BusinessLocation { get; set; }
        public short BusinessLocationId { get; set; }
    }
}
