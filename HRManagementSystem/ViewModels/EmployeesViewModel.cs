using HRManagementSystem.Persistence.Repositories;
using System.Collections.ObjectModel;

namespace HRManagementSystem.ViewModels
{
    public class EmployeesViewModel : IViewModel
    {
        private readonly IUnitOfWork _unitOfwork;
        public ObservableCollection<EmployeeViewModel> Employees { get; set; } = [];

        public EmployeesViewModel(IUnitOfWork unitOfWork)
        {
            _unitOfwork = unitOfWork;
            LoadData();
        }
        private void LoadData()
        {
            var data = _unitOfwork.Employees.GetAllActiveEmployeesWithDeptAndPfp();
            foreach(EmployeeViewModel employee in data)
            {
                Employees.Add(employee);
            }
        }
    }
}
