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
    /// Interaction logic for DonHang.xaml
    /// </summary>
    public partial class DonHang : UserControl
    {
        BUS_USER user_bus = new BUS_USER();
        public DonHang()
        {
            InitializeComponent();
            DonhangLV.ItemsSource = user_bus.getallDH();
        }

        
        private void bntThemDH_Click(object sender, RoutedEventArgs e)
        {
            ThemDonHang them = new ThemDonHang();
            them.Show();
        }

        private void DonhangLV_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (DonhangLV.SelectedItems.Count==1)
            {
                CTDonHang inst = new CTDonHang();
                inst.initdata((Donhang)DonhangLV.SelectedItems[0]);
                inst.Show();
            }
        }
        private void listview_filter(string keyword)
        {
            DonhangLV.ItemsSource = user_bus.getallDH().Where(dhi => user_bus.getkh(dhi.KhachhangID).tenkh.ToLower().Contains(keyword.ToLower())
              || dhi.KhachhangID.ToLower().Contains(keyword.ToLower()) || dhi.ngaythem.ToLower().Contains(keyword.ToLower())
              ||dhi.DonhangID.ToLower().Contains(keyword.ToLower()));
        }
        private void ListViewSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                listview_filter(ListViewSearchBar.Text);
        }

        private void bntThemHD_Click(object sender, RoutedEventArgs e)
        {
            CTHoaDon cthoadon_window = new CTHoaDon();
            cthoadon_window.init_data((Donhang)DonhangLV.SelectedItems[0]);
            cthoadon_window.Show();
        }

        private void bthSearchBook_Click(object sender, RoutedEventArgs e)
        {
            listview_filter(ListViewSearchBar.Text);
        }

        private void DonhangLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DonhangLV.SelectedItems.Count == 1)
                bntThemHD.IsEnabled = true;
            else bntThemHD.IsEnabled = false;
        }
    }
}
