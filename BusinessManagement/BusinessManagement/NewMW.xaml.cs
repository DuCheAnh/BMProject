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
    /// Interaction logic for NewMW.xaml
    /// </summary>
    public partial class NewMW : Window
    {
        bool loggingout = false;
        BUS_USER user_bus = new BUS_USER();
        void NhanVienLogin()
        {
            btnPb.Visibility = Visibility.Hidden;
            epQL.Visibility = Visibility.Collapsed;
        }
        void QuanLyLogin()
        {
            
            btnThemHopDong.Visibility = Visibility.Collapsed;
            btnThemMatHang.Visibility = Visibility.Collapsed;
            btnThemNhaCC.Visibility = Visibility.Collapsed;
        }
        void GiamDocLogin()
        {
            //btnQLPhongBan.Visibility = Visibility.Collapsed;
        }

        public NewMW()
        {
            InitializeComponent();
            if (CurrentUser.nhanvien.type == "GD")
            {
                GiamDocLogin();
            }
            else
            {
            string logintype = user_bus.get_lastcv(BUS.CurrentUser.nhanvien.CTChucvuID).ChucvuID;
                switch (logintype)
                {
                    case "NVCT":
                        NhanVienLogin();
                        break;
                    case "QL":
                        QuanLyLogin();
                        break;
                    case "GD":
                        GiamDocLogin();
                        break;
                }
            }
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

        private void btnAddNV_Click(object sender, RoutedEventArgs e)
        {
            ThemNVMoi them = new ThemNVMoi();
            them.Show();
        }

        private void btnQLPhongBan_Click(object sender, RoutedEventArgs e)
        {
            spMain.Children.Clear();
            PhongBan pb = new PhongBan();
            spMain.Children.Add(pb);
        }

        private void btnQLNV_Click(object sender, RoutedEventArgs e)
        {
            spMain.Children.Clear();
            NhanVien nv = new NhanVien();
            spMain.Children.Add(nv);
        }

        private void btnQLGioLam_Click(object sender, RoutedEventArgs e)
        {
            spMain.Children.Clear();
            QLNgayGio pb = new QLNgayGio();
            spMain.Children.Add(pb);
        }

        private void btnDGKN_Click(object sender, RoutedEventArgs e)
        {
            spMain.Children.Clear();
            LichDGKN pb = new LichDGKN();
            spMain.Children.Add(pb);
        }

        private void btnTKNV_Click(object sender, RoutedEventArgs e)
        {
            spMain.Children.Clear();
            ThongKe pb = new ThongKe();
            spMain.Children.Add(pb);
        }

        private void btnPhongBan_Click(object sender, RoutedEventArgs e)
        {
            spMain.Children.Clear();
            if (CurrentUser.nhanvien.type=="GD")
            {
                DSPhongBan pb = new DSPhongBan();
                spMain.Children.Add(pb);
            }
            else

            {
                PhongBan pb = new PhongBan();
                pb.initPhongbanpage(user_bus.getpb(BUS.CurrentUser.nhanvien.PBID));
                spMain.Children.Add(pb);
            }
        }
        private void btnThemMatHang_Click(object sender, RoutedEventArgs e)
        {
            ThemMatHang them = new ThemMatHang();
            them.Show();
        }

        private void btnThemHopDong_Click(object sender, RoutedEventArgs e)
        {
            ThemDienHD them = new ThemDienHD();
            them.Show();
        }
       
        private void btnThemNhaCC_Click(object sender, RoutedEventArgs e)
        {
            ThemNCC them = new ThemNCC();
            them.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbTenUser.Content = BUS.CurrentUser.nhanvien.tennv;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            loggingout = true;
            CurrentUser.nhanvien = null;
            CurrentUser.user = null;
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Close();


        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (!loggingout)
            Environment.Exit(Environment.ExitCode);
        }
    }
}

