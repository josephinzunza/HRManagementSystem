using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HRManagementSystem.Persistence.Repositories;

namespace HRManagementSystem.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private IViewModel currentViewModel;
        private readonly IUnitOfWork _unitOfWork;
        public MainWindowViewModel(IUnitOfWork unitOfWork)
        {
            currentViewModel = new DashboardViewModel();
            _unitOfWork = unitOfWork;
        }

        [RelayCommand]
        private void GoToDashboard()
        {
            CurrentViewModel = new DashboardViewModel();
        }
        [RelayCommand]
        private void GoToEmployees()
        {
            CurrentViewModel = new EmployeesViewModel(_unitOfWork);
        }
    }
}
