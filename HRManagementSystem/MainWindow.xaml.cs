using HRManagementSystem.Controls;
using System.Windows;
using System.Windows.Controls;

namespace HRManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var sideBar = (ListBox)sender; 
        }
    }
}