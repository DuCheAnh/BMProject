using BUS;
using DTO;
using System.Linq;
using System.Windows;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for CTKhachHang.xaml
    /// </summary>
    public partial class CTKhachHang : Window
    {
        BUS_USER user_bus = new BUS_USER();
        Khachhang kh = new Khachhang();
        public CTKhachHang()
        {
            InitializeComponent();
        }
        public void initdata(Khachhang data)
        {
            kh = data;
            this.DataContext = kh;
            dhlistview.ItemsSource = user_bus.getallDH().Where(dh => dh.KhachhangID == kh.KhachhangID);
        }

        private void rmbtn_Click(object sender, RoutedEventArgs e)
        {
            if (user_bus.remove_KH(kh.KhachhangID))
                this.Close();
        }

        private void editbtn_Click(object sender, RoutedEventArgs e)
        {
            Khachhang inst = new Khachhang();
            inst.KhachhangID = lbMaKH.Text;
            inst.tenkh = lbTenKH.Text;
            inst.sdt = lbSDT.Text;
            inst.diachi = lbDiaChi.Text;
            if (user_bus.update_KH(inst))
                MessageBox.Show("nice");
        }
    }
}
