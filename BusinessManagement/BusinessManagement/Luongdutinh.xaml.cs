using BUS;
using DTO;
using System.Windows;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for Luongdutinh.xaml
    /// </summary>
    public partial class Luongdutinh : Window
    {
        BUS_USER user_bus = new BUS_USER();
        public Luongdutinh()
        {
            InitializeComponent();
            init_data(BUS.CurrentUser.nhanvien);
        }
        public void init_data(Nhanvien data)
        {

            LTTlb.Content = user_bus.getkyket(data.CTKyketID).luongkyket;
            LLTlb.Content = user_bus.getctlamthem(data.CTLamthemID).sogiolamthem * 30000;
            LTlb.Content = user_bus.getmucthuong_fromctt(data.CTThuongID).thuong;

            LCVlb.Content = user_bus.getchucvu(user_bus.get_lastcv(data.CTChucvuID).ChucvuID).thuongchucvu;
            Tonglb.Content = long.Parse(LTTlb.Content.ToString()) +
                long.Parse(LLTlb.Content.ToString()) + long.Parse(LTlb.Content.ToString()) + long.Parse(LCVlb.Content.ToString());
        }
    }
}
