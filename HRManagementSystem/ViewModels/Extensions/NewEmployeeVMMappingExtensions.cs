
using HRManagementSystem.Models;

namespace HRManagementSystem.ViewModels.Extensions
{
    static class NewEmployeeVMMappingExtensions
    {
        public static Employee ToEmployee(this NewEmployeeViewModel newEmployeeVM)
        {
            return new Employee
            {
                FirstName = newEmployeeVM.FirstName,
                LastName = newEmployeeVM.LastName,
                DateOfBirth = newEmployeeVM.DateOfBirth,
                Gender = newEmployeeVM.Gender == "Other (specify)" ? newEmployeeVM.GenderOther : newEmployeeVM.Gender,
                PhoneNumber = newEmployeeVM.PhoneNumber,
                Email = newEmployeeVM.Email,
                Address = newEmployeeVM.Address,
                City = newEmployeeVM.City,
                StateId = newEmployeeVM.SelectedState.Id,
                ZipCode = newEmployeeVM.ZipCode,
            };
        }
    }
}
