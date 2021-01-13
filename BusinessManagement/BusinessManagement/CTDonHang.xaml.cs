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
using DTO;
using BUS;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for CTDonHang.xaml
    /// </summary>
    public partial class CTDonHang : Window
    {
        BUS_USER user_bus = new BUS_USER();
        public CTDonHang()
        {
            InitializeComponent();
        }
        public void initdata(Donhang data)
        {
            lbMaKH.Content = user_bus.getkh(data.KhachhangID).tenkh;
            ctdhLV.ItemsSource=user_bus.transferCTDH(data);
            lbTongTien.Content = data.trigia;
        }
    }
}
