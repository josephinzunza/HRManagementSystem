using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace HRManagementSystem.Controls;
public class ValidationTextBox : TextBox, INotifyPropertyChanged
{
    public ValidationTextBox() : base()
    {
        IsPlaceholderVisible = string.IsNullOrWhiteSpace(Text);
        CurrentPlaceholderText = PlaceholderText;
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
    private bool alwaysShowPlaceholder = false;

    public bool AlwaysShowPlaceholder
    {
        get { return alwaysShowPlaceholder; }
        set { alwaysShowPlaceholder = value; }
    }

    protected override void OnTextChanged(TextChangedEventArgs e)
    {
        base.OnTextChanged(e);
    }
    private string currentPlaceholderText = string.Empty;

    public string CurrentPlaceholderText
    {
        get { return currentPlaceholderText; }
        set { currentPlaceholderText = value; OnPropertyChanged(nameof(CurrentPlaceholderText)); }
    }

    public string PlaceholderText
    {
        get { return (string)GetValue(PlaceholderTextProperty); }
        set { SetValue(PlaceholderTextProperty, value); CurrentPlaceholderText = (string)GetValue(PlaceholderTextProperty); }
    }

    // Using a DependencyProperty as the backing store for PlaceholderText.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty PlaceholderTextProperty =
        DependencyProperty.Register("PlaceholderText", typeof(string), typeof(ValidationTextBox), new PropertyMetadata(defaultValue: string.Empty));

    public event PropertyChangedEventHandler? PropertyChanged;

    static ValidationTextBox()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(ValidationTextBox), new FrameworkPropertyMetadata(typeof(ValidationTextBox)));
    }

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    protected void SetPlaceholderText()
    {
        if (AlwaysShowPlaceholder)
        {
            if (PlaceholderText.Length <= Text.Length)
                CurrentPlaceholderText = Text;
            else
                CurrentPlaceholderText = Text + PlaceholderText[Text.Length..];
        }
        else
        {
            if (string.IsNullOrEmpty(Text))
                CurrentPlaceholderText = PlaceholderText;
            else
                CurrentPlaceholderText = "";
        }
    }
    protected override void OnInitialized(EventArgs e)
    {
        CurrentPlaceholderText = PlaceholderText;
        base.OnInitialized(e);
    }
}
