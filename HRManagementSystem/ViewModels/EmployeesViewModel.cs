using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace HRManagementSystem.ViewModels
{
    class EmployeeViewModel
    {
        public Image ProfilePicture { get; set; } = new();
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
    }

    class EmployeesViewModel
    {
        public ObservableCollection<EmployeeViewModel> Employees { get; set; } = [];
    }
}
