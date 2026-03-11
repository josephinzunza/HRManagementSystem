using System;
using System.Collections.Generic;
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
    /// Interaction logic for TopToolbar.xaml
    /// </summary>
    public partial class TopToolbar : UserControl
    {
        public TopToolbar()
        {
            InitializeComponent();
        }



        public Uri LogoSource
        {
            get { return (Uri)GetValue(LogoSourceProperty); }
            set { SetValue(LogoSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LogoSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LogoSourceProperty =
            DependencyProperty.Register("LogoSource", typeof(Uri), typeof(TopToolbar), new PropertyMetadata(default));


    }
}
