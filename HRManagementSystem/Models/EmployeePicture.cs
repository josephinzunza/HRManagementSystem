namespace HRManagementSystem.Models
{
    public class EmployeePicture
    {
        public int Id { get; set; }
        public Employee? Employee { get; set; }
        public int EmployeeId { get; set; }
        public byte[] ImageData { get; set; } = [];
    }
}
