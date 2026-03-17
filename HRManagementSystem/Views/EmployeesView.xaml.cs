using System.Windows.Controls;
using HRManagementSystem.Persistence.Repositories;
using HRManagementSystem.ViewModels;

namespace HRManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for EmployeesView.xaml
    /// </summary>
    public partial class EmployeesView : Page
    {
        public EmployeesView()
        {
            InitializeComponent();

            DataContext = new EmployeesViewModel(new EmployeeRepository(new HRMSDbContext()));
        }
    }
}
