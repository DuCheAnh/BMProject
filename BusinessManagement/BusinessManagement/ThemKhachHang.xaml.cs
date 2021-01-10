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
using System.Windows.Shapes;
using BUS;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for ThemKhachHang.xaml
    /// </summary>
    public partial class ThemKhachHang : Window
    {
        BUS_USER user_bus = new BUS_USER();
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnThemKH_Click(object sender, RoutedEventArgs e)
        {
            user_bus.add_new_KH(HoTen.Text, SDT.Text, DiaChi.Text);
            MessageBox.Show("Thêm thành công");
        }
    }
}
