using System.ComponentModel.DataAnnotations;

namespace HRManagementSystem.ValidationRules;

public class DateValidationRule : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is string dateString)
        {
            if (DateOnly.TryParse(dateString, out DateOnly _))
                return ValidationResult.Success;
        }
        return new ValidationResult("Invalid date format.");
    }
}
