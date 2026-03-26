using System.Windows;
using HRManagementSystem.Persistence.Repositories;
using HRManagementSystem.ViewModels;

namespace HRManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for NewEmployeeWindow.xaml
    /// </summary>
    public partial class NewEmployeeWindow : Window
    {
        public NewEmployeeWindow()
        {
            InitializeComponent();
            
            IUnitOfWork unitOfWork = new UnitOfWork(new HRMSDbContext());
            var viewModel = new NewEmployeeViewModel(unitOfWork);
            DataContext = viewModel;
        }
    }
}
