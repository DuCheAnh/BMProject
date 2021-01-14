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
using DTO;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for DoiChucVu.xaml
    /// </summary>
    public partial class DoiChucVu : Window
    {
        BUS_USER user_bus = new BUS_USER();
        Nhanvien nv = new Nhanvien();
        public DoiChucVu()
        {
            InitializeComponent();
        }

        public void init_data(Nhanvien data)
        {
            nv = data;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user_bus.update_chucvuNV(nv,chucvucbbox.Text);
        }
    }
}
