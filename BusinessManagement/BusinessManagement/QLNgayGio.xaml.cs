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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BUS;
using DTO;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for QLNgayGio.xaml
    /// </summary>
    public partial class QLNgayGio : UserControl
    {
        BUS_USER user_bus = new BUS_USER();
        public QLNgayGio()
        {
            InitializeComponent();
            lamthemlistview.ItemsSource = user_bus.get_allctlt();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CapnhatLamthem inst = new CapnhatLamthem();
            inst.init_data((CTLamthem)lamthemlistview.SelectedItems[0]);
            inst.Show();
        }
    }
}
