using BUS;
using DTO;
using System.Windows;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for DangNhap.xaml
    /// </summary>
    public partial class DangNhap : Window
    {
        BUS_USER user_bus = new BUS_USER();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void a(object sender, RoutedEventArgs e)
        {
            MainWindow mn = new MainWindow();
            mn.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            UserData user = user_bus.search_user(Username.Text);
            
            if (user != null && user.matkhau == Password.Password)
            //BUS.CurrentUser.user = user_bus.get_user_from_id("637459267331457059");
            {
                CurrentUser.user = user_bus.get_user_from_id(user.uid);
                CurrentUser.nhanvien = user_bus.get_nv_from_id(user.NVID);
                MainWindow mn = new MainWindow();
                mn.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("sai");
            }
        }

    }
}
