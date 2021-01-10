using System.Windows;
using System.Windows.Controls;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for CaNhan.xaml
    /// </summary>
    public partial class CaNhan : UserControl
    {
        public CaNhan()
        {
            InitializeComponent();
        }
        private void User_info_load(string nTennv, string nManv, string nNgaysinh, string nGioitinh, string nNoisinh,
                                    string nDiachi, string nTrinhdo, string nPBhientai)
        {
            lbTenNV.Content = nTennv;
            lbMaNV.Content = nManv;
            lbNgaySinh.Content = nNgaysinh;
            lbGioiTinh.Content = nGioitinh;
            lbNoiSinh.Content = nNoisinh;
            lbDiaChi.Content = nDiachi;
            lbTrinhDo.Content = nTrinhdo;
            lbPhongBan.Content = nPBhientai;
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            lbTenNV.Content = BUS.CurrentUser.nhanvien.tennv;
            lbMaNV.Content = BUS.CurrentUser.nhanvien.NVID;
            lbNgaySinh.Content = BUS.CurrentUser.nhanvien.email;
            lbGioiTinh.Content = BUS.CurrentUser.nhanvien.CTThuongID;
            lbNoiSinh.Content = BUS.CurrentUser.nhanvien.type;
            lbDiaChi.Content = BUS.CurrentUser.nhanvien.CTLamthemID;
            lbTrinhDo.Content = BUS.CurrentUser.nhanvien.CTChucvuID;
            lbPhongBan.Content = BUS.CurrentUser.user.PBID;
            
        }
    }
}
