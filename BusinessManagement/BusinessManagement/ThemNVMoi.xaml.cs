using BUS;
using System.Windows;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (user_bus.add_new_nv(HoTen.Text, MaNV.Text, Username.Text, Password.Password, DOB.SelectedDate.ToString(),
                Gender.Text, BirthPlace.Text, Address.Text, Position.Text, HopDong.Text, HDtill.SelectedDate.ToString(), Trinhdo.Text, "PB01"))
                MessageBox.Show("them thanh cong");
            else MessageBox.Show("them tha bai");
        }
    }
}
