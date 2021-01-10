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
    /// Interaction logic for ThemNVMoi.xaml
    /// </summary>
    public partial class ThemNVMoi : Window
    {
        BUS_USER user_bus = new BUS_USER();
        public ThemNVMoi()
        {
            InitializeComponent();
        }

        private void btnThemNV_Click(object sender, RoutedEventArgs e)
        {
            if (user_bus.add_new_nv(HoTen.Text, MaNV.Text, Username.Text, Password.Password, DOB.SelectedDate.ToString(),
                Gender.Text, BirthPlace.Text, Address.Text, Position.Text, HopDong.Text, HDtill.SelectedDate.ToString(), TrinhDo.Text, "PB01"))
                MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bại");
        }
    }
}
