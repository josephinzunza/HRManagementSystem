namespace HRManagementSystem.Models
{
    public class Department
    {
        public byte Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Employee? Manager { get; set; }
        public uint ManagerId { get; set; }
    }
}
