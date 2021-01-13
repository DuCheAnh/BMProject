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
            User_info_load(BUS.CurrentUser.nhanvien.tennv, BUS.CurrentUser.nhanvien.NVID, BUS.CurrentUser.nhanvien.ngaysinh
                , BUS.CurrentUser.nhanvien.gioitinh, BUS.CurrentUser.nhanvien.noisinh, BUS.CurrentUser.nhanvien.diachi,
                BUS.CurrentUser.nhanvien.trinhdo, BUS.CurrentUser.user.PBID);
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
            
        }
    }
}
