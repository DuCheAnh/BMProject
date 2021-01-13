using System.Windows;
using System.Windows.Controls;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for CaNhan.xaml
    /// </summary>
    public partial class CaNhan : UserControl
    {
        public CaNhan()
        {
            InitializeComponent();
            this.DataContext = BUS.CurrentUser.nhanvien;
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
