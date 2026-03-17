using HRManagementSystem.ViewModels;

namespace HRManagementSystem.Models.Mappers
{
    public static class EmployeeMappingExtensions
    {
        public static EmployeeViewModel ToEmployeeViewModel(this Employee employee)
        {
            return new EmployeeViewModel
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber,
            };
        }
    }
}
