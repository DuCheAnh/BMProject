using BUS;
using DTO;
using System;
using System.Windows;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for TThoadon.xaml
    /// </summary>
    public partial class TThoadon : Window
    {
        BUS_USER user_bus = new BUS_USER();
        Hoadon current = new Hoadon();
        public TThoadon()
        {
            InitializeComponent();
        }
        public void initdata(Hoadon data)
        {
            current = data;
            Donhang inst = user_bus.getdonhang(data.DonhangID);
            lbMaKH.Content += user_bus.getkh(inst.KhachhangID).tenkh;
            ctdhLV.ItemsSource = user_bus.transferCTDH(inst);
            lbNgaylap.Content += inst.ngaythem;
            lbTongTien.Content = inst.trigia;
            lbNgayxuat.Content += DateTime.Now.ToString();
        }

        private void xuathdbtn_Click(object sender, RoutedEventArgs e)
        {
            current.ngayxuat = DateTime.Now.ToString();
            if (user_bus.update_hoadon(current))
                MessageBox.Show("Đã lưu ngày xuất");
        }
    }
}
