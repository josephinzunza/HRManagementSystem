
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

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
    ///     <MyNamespace:ValidationDateTextBox/>
    ///
    /// </summary>
    public class ValidationDateTextBox : TextBox, INotifyPropertyChanged
    {
        static ValidationDateTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ValidationDateTextBox), new FrameworkPropertyMetadata(typeof(ValidationDateTextBox)));
        }

        public ValidationDateTextBox() : base()
        {
            MaxLength = 10;
            DataObject.AddPastingHandler(this, OnPaste);
            Loaded += OnLoaded;
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private static readonly string digitsRegex = @"\d+";
        private static readonly string dateRegex = @"\d{2}/\d{2}/\d{4}";
        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            // Logic to execute when the button is ready
            CurrentPlaceholder = PlaceholderText;

        }
        protected override void OnPreviewTextInput(TextCompositionEventArgs e)
        {
            var textIsDigitsOnly = Regex.IsMatch(e.Text, digitsRegex);

            if (textIsDigitsOnly) AddText(e.Text);
            
            e.Handled = true;

            base.OnPreviewTextInput(e);
        }
        // Allow only properly-formatted dates to be pasted. Nothing else
        private void OnPaste(object sender, DataObjectPastingEventArgs e)
        {
            var isText = e.SourceDataObject.GetDataPresent(DataFormats.UnicodeText, true);
            if (!isText) return;

            var text = (string)e.SourceDataObject.GetData(DataFormats.UnicodeText);
            if (Regex.IsMatch(text, digitsRegex))
            {
                DataObject d = new();
                d.SetData(DataFormats.Text, string.Empty);
                e.DataObject = d;
                AddText(text);
            }
            else if (!Regex.IsMatch(text, dateRegex))
            {
                DataObject d = new();
                d.SetData(DataFormats.Text, string.Empty);

                e.DataObject = d;
            }
            
        }
        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            var text = Text + PlaceholderText[Text.Length..];
            CurrentPlaceholder = text;
            base.OnTextChanged(e);
        }
        private string currentPlaceholder = string.Empty;

        public string CurrentPlaceholder
        {
            get { return currentPlaceholder; }
            set
            {
                currentPlaceholder = value;
                OnPropertyChanged(nameof(CurrentPlaceholder));
            }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public string PlaceholderText
        {
            get { return (string)GetValue(PlaceholderTextProperty); }
            set { SetValue(PlaceholderTextProperty, value); CurrentPlaceholder = value; }
        }

        // Using a DependencyProperty as the backing store for PlaceholderText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaceholderTextProperty =
            DependencyProperty.Register("PlaceholderText", typeof(string), typeof(ValidationDateTextBox), new PropertyMetadata(defaultValue: string.Empty));

        private void AddText(string textToAdd)
        {
            var digits = new string([.. Text.Where(char.IsDigit)]);
            int insertionIndex = CaretIndex;
            if (insertionIndex >= 6) insertionIndex--;
            if (insertionIndex >= 3) insertionIndex--;
            int allowedDigits = 8 - insertionIndex;
            if (textToAdd.Length > allowedDigits) textToAdd = textToAdd[..allowedDigits];
            int slashesAdded = 0;
            int finalCaretIndex = CaretIndex + textToAdd.Length;
            if (CaretIndex < 2) slashesAdded = finalCaretIndex >= 4 ? 2 : finalCaretIndex >= 2 ? 1 : 0;
            else if (insertionIndex < 4) slashesAdded = finalCaretIndex >= 4 ? 1 : 0;
            digits = digits.Insert(insertionIndex, textToAdd);
            Text = FormatPhoneNumber(digits);
            finalCaretIndex += slashesAdded;
            CaretIndex = finalCaretIndex;
        }
        private static string FormatPhoneNumber(string digits)
        {
            string formatted;

            if (digits.Length < 2)
            {
                formatted = digits;
            }
            else if (digits.Length < 4)
            {
                formatted = $"{digits[0..2]}/{digits[2..]}";
            }
            else
            {
                formatted = $"{digits[0..2]}/{digits[2..4]}/{digits[4..]}";
            }
            return formatted;
        }
    }
}
