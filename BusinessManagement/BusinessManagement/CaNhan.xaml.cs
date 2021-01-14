using BUS;
using System.Windows;
using System.Windows.Controls;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for CaNhan.xaml
    /// </summary>
    public partial class CaNhan : UserControl
    {
        BUS_USER user_bus = new BUS_USER();
        public CaNhan()
        {
            InitializeComponent();
            this.DataContext = BUS.CurrentUser.nhanvien;
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ctluongbtn_Click(object sender, RoutedEventArgs e)
        {
            Luongdutinh inst = new Luongdutinh();
            inst.Show();
        }

        private void btnCTCV_Click(object sender, RoutedEventArgs e)
        {
            DSChucvuCanhan inst = new DSChucvuCanhan();
            inst.initdata(user_bus.getctcv(BUS.CurrentUser.nhanvien.CTChucvuID));
            inst.Show();
        }

        private void ctkinangbtn_Click(object sender, RoutedEventArgs e)
        {
            DSKinangCanhan inst = new DSKinangCanhan();
            inst.initdata(user_bus.get_dskn(BUS.CurrentUser.nhanvien.DSKinangID));
            inst.Show();
        }
    }
}
