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
    /// Interaction logic for ThemDienHD.xaml
    /// </summary>
    public partial class ThemDienHD : Window
    {
        BUS_USER user_bus = new BUS_USER();
        public ThemDienHD()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            long luongcb = Convert.ToInt32(LuongCB.Text);
            if (user_bus.add_new_HD(MaHD.Text, TenHD.Text, luongcb, Chitiet.Text))
                MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bại");
        }
    }
}
