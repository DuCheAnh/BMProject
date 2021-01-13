using BUS;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for ThemMatHang.xaml
    /// </summary>
    public partial class ThemMatHang : Window
    {
        BUS_USER user_bus = new BUS_USER();
        public ThemMatHang()
        {
            InitializeComponent();
        }
        private void tbTenMH_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnThemMH_Click(object sender, RoutedEventArgs e)
        {
            if (user_bus.add_new_HH(tbMahang.Text,tbTenMH.Text, cbNCC.Text, tbDVT.Text, cbNhomMH.Text, long.Parse(tbDonGia.Text)))
                MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bại");

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> listcc = user_bus.getallNCC_ID();
            cbNCC.ItemsSource = listcc;
        }
    }
}
