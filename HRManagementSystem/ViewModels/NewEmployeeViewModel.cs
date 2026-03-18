using CommunityToolkit.Mvvm.Input;
using HRManagementSystem.Models;
using HRManagementSystem.Persistence.Repositories;
using HRManagementSystem.ViewModels.Extensions;
using System.Collections;
using System.ComponentModel;

namespace HRManagementSystem.ViewModels
{
    public partial class NewEmployeeViewModel : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        private readonly IUnitOfWork UnitOfWork;

        public event PropertyChangedEventHandler? PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        private readonly Dictionary<string, List<string>> propertyErrors = [];

        public NewEmployeeViewModel(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            States = UnitOfWork.States.GetAll();
        }
        // Data sources
        public IEnumerable<State> States { get; private set; }
        public string[] Genders { get; private set; } =
            ["Woman", "Man", "Non-binary", "Other (specify)", "Prefer not to say"];
        // New employee properties
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
        private string genderOther = string.Empty;
        public string GenderOther
        {
            get { return genderOther; }
            set
            { 
                genderOther = value;
                OnPropertyChanged(nameof(GenderOther));
            }
        }

        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public State SelectedState { get; set; } = new State();
        public string ZipCode { get; set; } = string.Empty;
        private bool isGenderOtherEnabled;

        public bool IsGenderOtherEnabled
        {
            get { return isGenderOtherEnabled; }
            set 
            {
                isGenderOtherEnabled = value;
                OnPropertyChanged(nameof(IsGenderOtherEnabled));
            }
        }

        public bool HasErrors => propertyErrors.Any(kvp => kvp.Value.Count > 0);

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        // Commands
        [RelayCommand]
        private void GenderSelectionChanged(int selectedIndex)
        {
            if (selectedIndex != 3)
            {
                GenderOther = string.Empty;
                IsGenderOtherEnabled = false;
            }
            else
            {
                IsGenderOtherEnabled = true;
            }
        }
        [RelayCommand]
        private void AddNewEmployee()
        {
            Employee employee = this.ToEmployee();
            UnitOfWork.Employees.Add(employee);
            UnitOfWork.Complete();
        }

        public IEnumerable GetErrors(string? propertyName)
        {
            if (propertyName == null)
                return Enumerable.Empty<string>();
            return propertyErrors[propertyName];
        }
        private void AddError(string propertyName, string errorMessage)
        {
            if (!propertyErrors.ContainsKey(propertyName))
            {
                propertyErrors[propertyName] = new List<string>();
            }
            propertyErrors[propertyName].Add(errorMessage);
            OnErrorsChanged(propertyName);
        }
        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }
    }
}
