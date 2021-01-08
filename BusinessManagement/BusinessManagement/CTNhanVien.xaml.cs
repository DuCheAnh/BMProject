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

namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for CTNhanVien.xaml
    /// </summary>
    public partial class CTNhanVien : Window
    {
        public CTNhanVien()
        {
            InitializeComponent();
        }

        private void btnDoiChucVu_Click(object sender, RoutedEventArgs e)
        {
            DoiChucVu dcv = new DoiChucVu();
            dcv.Show();
        }

        private void btnThemHopDong_Click(object sender, RoutedEventArgs e)
        {
            ThemHopDong thd = new ThemHopDong();
            thd.Show();
        }
    }
}
