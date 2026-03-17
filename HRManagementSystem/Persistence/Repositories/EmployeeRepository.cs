using HRManagementSystem.Models;
using HRManagementSystem.ViewModels;

namespace HRManagementSystem.Persistence.Repositories
{
    public class EmployeeRepository(HRMSDbContext HRMSDbContext) : Repository<Employee>(HRMSDbContext), IEmployeeRepository
    {
        public IEnumerable<EmployeeViewModel> GetAllActiveEmployeesWithDeptAndPfp()
        {
            var employeeJobTitles = HRMSDbContext.EmployeeJobTitle;
            var jobTitles = HRMSDbContext.JobTitles;
            var departments = HRMSDbContext.Departments;
            var employees = HRMSDbContext.Employees;
            var employeePfps = HRMSDbContext.EmployeePictures;

            var query = from employeeJobTitle in employeeJobTitles
                        join jobTitle in jobTitles on employeeJobTitle.JobTitleId equals jobTitle.Id
                        join department in departments on jobTitle.DepartmentId equals department.Id
                        join employee in employees on employeeJobTitle.EmployeeId equals employee.Id
                        join employeePfp in employeePfps on employee.Id equals employeePfp.Id
                        where employeeJobTitle.IsCurrentTitle && employee.IsActive
                        select new EmployeeViewModel
                        {
                            Department = department.Name,
                            Email = employee.Email,
                            FirstName = employee.FirstName,
                            LastName = employee.LastName,
                            PhoneNumber = employee.PhoneNumber,
                            ProfilePicture = employeePfp.ImageData
                        };

            return [.. query];
        }
    }
}
