using HRManagementSystem.Persistence.Repositories;
using System.Collections.ObjectModel;

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

    public class EmployeesViewModel
    {
        private readonly IEmployeeRepository _repository;
        public ObservableCollection<EmployeeViewModel> Employees { get; set; } = [];
        public EmployeesViewModel(IEmployeeRepository repository)
        {
            _repository = repository;
            LoadData();
        }
        private void LoadData()
        {
            var data = _repository.GetAllActiveEmployeesWithDeptAndPfp();
            foreach(EmployeeViewModel employee in data)
            {
                Employees.Add(employee);
            }
        }
    }
}
