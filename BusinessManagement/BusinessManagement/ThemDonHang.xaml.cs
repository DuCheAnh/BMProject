using BUS;
using System;
using System.Collections.Generic;
using System.Windows;
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
            List<string> list = user_bus.getallKH_ID();
            MaKH.ItemsSource = list;
        }

        private void btnThemMH_Click(object sender, RoutedEventArgs e)
        {
            ThemMoreMH mh = new ThemMoreMH();
            ThemMH.Children.Add(mh);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string mh_string = null;
            string sl_string = null;
            foreach (ThemMoreMH mh in ThemMH.Children)
            {
                mh_string += mh.getMaMH() + "/";
                sl_string += mh.getSL() + "/";
            }
            user_bus.add_new_dh("DH"+user_bus.new_DonhangID().ToString(), mh_string, DateTime.Now.ToString(), sl_string, MaKH.Text);
        }
    }
}
