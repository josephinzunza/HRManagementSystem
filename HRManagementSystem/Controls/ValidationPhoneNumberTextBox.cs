using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HRManagementSystem.Controls
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:HRManagementSystem.Controls"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:HRManagementSystem.Controls;assembly=HRManagementSystem.Controls"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:PhoneNumberTextBox/>
    ///
    /// </summary>
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
}