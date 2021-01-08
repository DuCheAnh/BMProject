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

namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        void NhanVienLogin()
        {
            btnAddNV.Visibility = Visibility.Collapsed;
            btnQLNV.Visibility = Visibility.Collapsed;
            btnQLPhongBan.Visibility = Visibility.Collapsed;
            btnQLGioLam.Visibility = Visibility.Collapsed;
            btnDGKN.Visibility = Visibility.Collapsed;
            btnTKNV.Visibility = Visibility.Collapsed;
            btnYeuCauGD.Visibility = Visibility.Collapsed;
            btnXemYeuCau.Visibility = Visibility.Collapsed;
        }
        void QuanLyLogin()
        {
            btnXemYeuCau.Visibility = Visibility.Collapsed;
        }
        void GiamDocLogin()
        {
            btnYeuCauGD.Visibility = Visibility.Collapsed;
        }
        public MainWindow()
        {
            InitializeComponent();
            //NhanVienLogin();
            QuanLyLogin();
            //GiamDocLogin();
        }

        private void btnDonHang_Click(object sender, RoutedEventArgs e)
        {
            spMain.Children.Clear();
            DonHang donhang = new DonHang();
            spMain.Children.Add(donhang);
        }

        private void bntKhachHang_Click(object sender, RoutedEventArgs e)
        {
            spMain.Children.Clear();
            KhachHang khachhang = new KhachHang();
            spMain.Children.Add(khachhang);
        }

        private void btnHoaDon_Click(object sender, RoutedEventArgs e)
        {
            spMain.Children.Clear();
            HoaDon hoadon = new HoaDon();
            spMain.Children.Add(hoadon);
        }

        private void btnHangHoa_Click(object sender, RoutedEventArgs e)
        {
            spMain.Children.Clear();
            HangHoa hanghoa = new HangHoa();
            spMain.Children.Add(hanghoa);
        }

        private void btnCaNhan_Click(object sender, RoutedEventArgs e)
        {
            spMain.Children.Clear();
            CaNhan canhan = new CaNhan();
            spMain.Children.Add(canhan);
        }

        private void btnDangXuat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnYeuCauGD_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnQLPhongBan_Click(object sender, RoutedEventArgs e)
        {
            spMain.Children.Clear();
            ThongQuaYC phongban = new ThongQuaYC();
            spMain.Children.Add(phongban);
         }
    }
}
