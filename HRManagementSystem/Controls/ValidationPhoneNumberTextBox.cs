using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HRManagementSystem.Controls;

public class ValidationPhoneNumberTextBox : ValidationTextBox
{
    public ValidationPhoneNumberTextBox() : base()
    {
        MaxLength = 14;
    }
    static ValidationPhoneNumberTextBox()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(ValidationPhoneNumberTextBox), new FrameworkPropertyMetadata(typeof(ValidationPhoneNumberTextBox)));
    }

    public string PhoneNumber
    {
        get { return (string)GetValue(PhoneNumberProperty); }
        set { SetValue(PhoneNumberProperty, value); }
    }

    // Using a DependencyProperty as the backing store for PhoneNumber.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty PhoneNumberProperty =
        DependencyProperty.Register("PhoneNumber", typeof(string), typeof(ValidationPhoneNumberTextBox), new PropertyMetadata(""));

    private static readonly string regex = @"\d+";

    protected override void OnPreviewTextInput(TextCompositionEventArgs e)
    {
        e.Handled = !Regex.IsMatch(e.Text, regex);

        base.OnPreviewTextInput(e);
    }

    protected override void OnTextChanged(TextChangedEventArgs e)
    {
        var digits = new string([.. Text.Where(char.IsDigit)]);
        Text = FormatPhoneNumber(digits);

        PhoneNumber = digits;

        // Move the caret to the end of the text
        CaretIndex = Text.Length;

        base.OnTextChanged(e);
    }

    private static string FormatPhoneNumber(string digits)
    {
        string formatted;

        if (digits.Length <= 3)
        {
            formatted = digits;
        }
        else if (digits.Length <= 6)
        {
            formatted = $"({digits[0..3]}) {digits[3..]}";
        }
        else
        {
            formatted = $"({digits[0..3]}) {digits[3..6]}-{digits[6..]}";
        }
        return formatted;
    }
}