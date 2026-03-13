
namespace HRManagementSystem.Models
{
    public class Employee
    {
        public uint Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address {  get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public State? State { get; set; }
        public byte StateId { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
        public string Gender {  get; set; } = string.Empty;
    }

    public class EmployeePicture
    {
        public uint EmployeeId { get; set; }
        public byte[] ImageData { get; set; } = [];
    }
}
