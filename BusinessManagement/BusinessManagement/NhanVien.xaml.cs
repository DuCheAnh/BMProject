using BUS;
using DTO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for NhanVien.xaml
    /// </summary>
    public partial class NhanVien : UserControl
    {
        BUS_USER user_bus = new BUS_USER();
        public NhanVien()
        {
            InitializeComponent();
            init_listview();
        }

        private void bntThemNV_Click(object sender, RoutedEventArgs e)
        {
            ThemNVMoi them = new ThemNVMoi();
            them.Show();
        }
        private void init_listview()
        {
            if(user_bus.get_lastcv(CurrentUser.nhanvien.CTChucvuID).ChucvuID=="QL")
            {
                NVListview.ItemsSource = user_bus.getallNV().Where(nv=>nv.PBID==CurrentUser.nhanvien.PBID);
            }
            else
                NVListview.ItemsSource = user_bus.getallNV();
        }
        private void filter_listview(string keyword)
        {
            NVListview.ItemsSource = user_bus.getallNV().Where(lvi => lvi.tennv.ToLower().Contains(keyword.ToLower()) ||
                            lvi.NVID.ToLower().Contains(keyword.ToLower())
                            || lvi.PBID.ToLower().Contains(keyword.ToLower()));
        }
        private void NVListview_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (NVListview.SelectedItems.Count == 1)
            {
                CTNhanVien ctnv_inst = new CTNhanVien();
                ctnv_inst.init_data((Nhanvien)NVListview.SelectedItems[0]);
                ctnv_inst.Show();
            }
        }

        private void ListViewSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                filter_listview(ListViewSearchBar.Text);
        }
    }
}
