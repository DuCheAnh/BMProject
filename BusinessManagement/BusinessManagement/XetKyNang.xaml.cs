using BUS;
using DTO;
using System.Windows;
using System;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for XetKyNang.xaml
    /// </summary>
    public partial class XetKyNang : Window
    {
        BUS_USER user_bus = new BUS_USER();
        Nhanvien nv = new Nhanvien();
        public XetKyNang()
        {
            InitializeComponent();
        }
        public void initdata(Nhanvien data)
        {
            nv = data;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DSKynang ds = user_bus.get_dskn(nv.DSKinangID);
            ds.tenkynang += tenkntb.Text+"/";
            ds.mucdo += mucdocb.Text + "/";
            ds.ngaydanhgia += DateTime.Now.ToString() + "-";
            if (user_bus.update_dskn(ds))
                MessageBox.Show("Thanh cong");
            
        }
    }
}
