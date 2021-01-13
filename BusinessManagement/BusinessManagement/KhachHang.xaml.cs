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
using DTO;
using BUS;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for KhachHang.xaml
    /// </summary>
    public partial class KhachHang : UserControl
    {
        BUS_USER user_bus = new BUS_USER();
        public KhachHang()
        {
            InitializeComponent();
            KHListview.ItemsSource = user_bus.getallKH();
        }

        private void bntThemKH_Click(object sender, RoutedEventArgs e)
        {
            ThemKhachHang them = new ThemKhachHang();
            them.Show();
        }
        private void listview_filter(string keyword)
        {
            KHListview.ItemsSource = user_bus.getallKH().Where(khi => khi.tenkh.ToLower().Contains(keyword.ToLower()) ||
                  khi.sdt.Contains(keyword) || khi.KhachhangID.ToLower().Contains(keyword.ToLower()) 
                  || khi.diachi.ToLower().Contains(keyword.ToLower()));
        }
        private void ListViewSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key==Key.Enter)
            {
                listview_filter(ListViewSearchBar.Text);
            }
        }
    }
}
