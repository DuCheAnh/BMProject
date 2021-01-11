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
    /// Interaction logic for ThemDonHang.xaml
    /// </summary>
    public partial class ThemDonHang : Window
    {
        BUS_USER user_bus = new BUS_USER();
        public ThemDonHang()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> list = user_bus.getallKH();
            MaKH.ItemsSource = list;
        }

        private void btnThemMH_Click(object sender, RoutedEventArgs e)
        {
            ThemMoreMH mh = new ThemMoreMH();
            ThemMH.Children.Add(mh);
        }
    }
}
