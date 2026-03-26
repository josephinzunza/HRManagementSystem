using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HRManagementSystem.Models;
using HRManagementSystem.Persistence.Repositories;
using HRManagementSystem.ViewModels.Extensions;
using HRManagementSystem.ValidationRules;
using System.ComponentModel.DataAnnotations;

namespace HRManagementSystem.ViewModels
{
    public partial class NewEmployeeViewModel : ObservableValidator
    {
        private readonly IUnitOfWork unitOfWork;

        public NewEmployeeViewModel(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            States = this.unitOfWork.States.GetAll();
        }
        // Data sources
        public IEnumerable<State> States { get; private set; }
        public string[] Genders { get; private set; } =
            ["Woman", "Man", "Non-binary", "Other (specify)", "Prefer not to say"];
        // New employee properties
       
        
        private string firstName = string.Empty;
        [Required]
        [MaxLength(128)]
        public string FirstName
        {
            get => firstName;
            set => SetProperty(ref firstName, value, true);
        }
        private string lastName = string.Empty;
        [Required]
        [MaxLength(128)]
        public string LastName
        {
            get => lastName;
            set => SetProperty(ref lastName, value, true);
        }

        
        private string dateOfBirth = string.Empty;
        [Required]
        [MinLength(10)]
        [DateValidationRule]
        public string DateOfBirth
        {
            get => dateOfBirth;
            set => SetProperty(ref dateOfBirth, value, true);
        }
        private string gender = string.Empty;
        [Required]
        public string Gender
        {
            get => gender;
            set => SetProperty(ref gender, value, true);
        }
        private string genderOther = string.Empty;
        [Required]
        [MaxLength(30)]
        public string GenderOther
        {
            get { return genderOther; }
            set
            { 
                ClearGenderOtherErrors();
                SetProperty(ref genderOther, value, true);
                OnPropertyChanged(nameof(GenderOther));
            }
        }
        private string phoneNumber = string.Empty;
        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be exactly 10 digits.")]
        public string PhoneNumber
        {
            get => phoneNumber;
            set => SetProperty(ref phoneNumber, value, true);
            
        }
        private string email = string.Empty;
        [Required]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format.")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string address = string.Empty;
        [Required]
        public string Address
        {
            get { return address; }
            set => SetProperty(ref address, value, true);
        }
        private string city = string.Empty;
        [Required]
        public string City
        {
            get { return city; }
            set => SetProperty(ref city, value, true);
        }

        private State? selectedState;
        [Required]
        public State? SelectedState
        {
            get => selectedState;
            set => SetProperty(ref selectedState, value, true);
        }
        private string zipCode = string.Empty;
        [Required]
        [RegularExpression(@"^[0-9]{5}", ErrorMessage = "Zip code must be exactly 5 digits.")]
        public string ZipCode
        {
            get => zipCode;
            set => SetProperty(ref zipCode, value, true);
        }
        [ObservableProperty]
        private bool isGenderOtherEnabled;

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
        private void ClearGenderOtherErrors()
        {
            if (!IsGenderOtherEnabled)
                ClearErrors(nameof(GenderOther));
        }
        [RelayCommand]
        private void AddNewEmployee()
        {
            ValidateAllProperties();
            ClearGenderOtherErrors();
            if (!HasErrors)
            {
                Employee employee = this.ToEmployee();
                unitOfWork.Employees.Add(employee);
                unitOfWork.Complete();
            }

        }
    }
}
