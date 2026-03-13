
namespace HRManagementSystem.Models
{
    public class BusinessLocation
    {
        public ushort Id { get; set; }
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public State? State { get; set; }
        public byte StateId { get; set; }
    }
}
