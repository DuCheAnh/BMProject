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
    /// Interaction logic for ThemNCC.xaml
    /// </summary>
    public partial class ThemNCC : Window
    {
        BUS_USER user_bus = new BUS_USER();
        public ThemNCC()
        {
            InitializeComponent();
        }

        private void btnThemNCC_Click(object sender, RoutedEventArgs e)
        {
            if (user_bus.add_new_NCC(tbMaNCC.Text, tbMaNCC.Text, "0100"))
                MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bại");
        }
    }
}
