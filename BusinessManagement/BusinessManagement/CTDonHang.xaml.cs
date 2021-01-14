using BUS;
using DTO;
using System.Windows;
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
            lbMaKH.Content += user_bus.getkh(data.KhachhangID).tenkh;
            ctdhLV.ItemsSource = user_bus.transferCTDH(data);
            lbNgaythang.Content += data.ngaythem;
            lbTongTien.Content = data.trigia;
        }
    }
}
