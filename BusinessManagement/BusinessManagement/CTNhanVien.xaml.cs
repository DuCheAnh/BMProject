using DTO;
using System.Windows;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for CTNhanVien.xaml
    /// </summary>
    public partial class CTNhanVien : Window
    {
        
        Nhanvien nv = new Nhanvien();
        public CTNhanVien()
        {
            InitializeComponent();
        }

        public void init_data(Nhanvien data)
        {
            nv = data;
            lbTenNV.Content = data.tennv;
            lbNgaySinh.Content = data.ngaysinh;
            lbGioiTinh.Content = data.gioitinh;
            lbNoiSinh.Content = data.noisinh;
            lbDiaChi.Content = data.diachi;
            lbTrinhDo.Content = data.trinhdo;
            lbPhongban.Content = data.PBID;

        }
        private void btnDoiChucVu_Click(object sender, RoutedEventArgs e)
        {
            DoiChucVu dcv = new DoiChucVu();
            dcv.init_data(nv);
            dcv.Show();
        }

        private void btnThemkinang_Click(object sender, RoutedEventArgs e)
        {
            XetKyNang xkn = new XetKyNang();
            xkn.initdata(nv);
            xkn.Show();
        }
    }
}
