using HRManagementSystem.Models;
using HRManagementSystem.ViewModels;

namespace HRManagementSystem.Persistence.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        IEnumerable<EmployeeViewModel> GetAllActiveEmployeesWithDeptAndPfp();
    }
}
