using BUS;
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

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (user_bus.loginchecker(UsernameBox.Text, PasswordBox.Password) != null)
            {
                MainWindow mn = new MainWindow();
                mn.Show();
                this.Close();
            }
            else MessageBox.Show("username or password is incorrect");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

    }
}
