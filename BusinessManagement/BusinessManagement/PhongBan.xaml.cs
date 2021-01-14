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
using DTO;
using BUS;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for PhongBan.xaml
    /// </summary>
    public partial class PhongBan : UserControl
    {
        BUS_USER user_bus = new BUS_USER();
        public PhongBan()
        {
            InitializeComponent();
        }
        public void initPhongbanpage(PBData data)
        {
            List<NVPBforDisplay> list= new List<NVPBforDisplay>();
            PBnameTB.Text = data.tenpb;
            
            foreach(Nhanvien var in user_bus.getallnv_fromPB(data))
            {
                NVPBforDisplay inst = new NVPBforDisplay();
                inst.tennv = var.tennv;
                inst.manv = var.NVID;
                inst.chucvu = var.type;
                inst.luongnv = 0;
                inst.luongnv+=user_bus.getkyket(var.CTKyketID).luongkyket;
                inst.luongnv += Convert.ToInt64(user_bus.getctlamthem(var.CTLamthemID).sogiolamthem * 30000);
                inst.luongnv += user_bus.getmucthuong_fromctt(var.CTThuongID).thuong;
                inst.luongnv+=user_bus.getchucvu(user_bus.get_lastcv(var.CTChucvuID).ChucvuID).thuongchucvu;
                list.Add(inst);
            }
            NVPBListview.ItemsSource = list;
            SonhanvienTB.Text+= NVPBListview.Items.Count;
        }
        private void btnThongKe_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void btnView_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
