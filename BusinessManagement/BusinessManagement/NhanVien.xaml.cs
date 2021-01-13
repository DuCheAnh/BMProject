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
using BUS;
using DTO;
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
            NVListview.ItemsSource = user_bus.getallNV();
        }

        private void NVListview_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (NVListview.SelectedItems.Count==1)
            {
                CTNhanVien ctnv_inst = new CTNhanVien();
                ctnv_inst.init_data((Nhanvien)NVListview.SelectedItems[0]);
                ctnv_inst.Show();
            }
        }
    }
}
