namespace HRManagementSystem.ViewModels
{
    public class EmployeeViewModel
    {
        public byte[] ProfilePicture { get; set; } = [];
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
    }
}
