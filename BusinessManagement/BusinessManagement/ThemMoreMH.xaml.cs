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

namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for ThemMoreMH.xaml
    /// </summary>
    public partial class ThemMoreMH : UserControl
    {
        BUS_USER user_bus = new BUS_USER();
        public ThemMoreMH()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> list = user_bus.getallMH();
            MaMH.ItemsSource = list;
        }
    }
}
