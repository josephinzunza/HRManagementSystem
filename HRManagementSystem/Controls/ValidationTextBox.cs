using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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
    ///     <MyNamespace:ValidationTextBox/>
    ///
    /// </summary>
    public class ValidationTextBox : TextBox, INotifyPropertyChanged
    {
        public ValidationTextBox() : base()
        {
            IsPlaceholderVisible = string.IsNullOrWhiteSpace(Text);
        }

        private bool isPlaceholderVisible;

        public bool IsPlaceholderVisible
        {
            get { return isPlaceholderVisible; }
            set
            {
                isPlaceholderVisible = value;
                OnPropertyChanged(nameof(IsPlaceholderVisible));
            }
        }

        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            IsPlaceholderVisible = string.IsNullOrWhiteSpace(Text);
            base.OnTextChanged(e);
        }

        public string PlaceholderText
        {
            get { return (string)GetValue(PlaceholderTextProperty); }
            set { SetValue(PlaceholderTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlaceholderText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaceholderTextProperty =
            DependencyProperty.Register("PlaceholderText", typeof(string), typeof(ValidationTextBox), new PropertyMetadata(""));

        public event PropertyChangedEventHandler? PropertyChanged;

        static ValidationTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ValidationTextBox), new FrameworkPropertyMetadata(typeof(ValidationTextBox)));
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
