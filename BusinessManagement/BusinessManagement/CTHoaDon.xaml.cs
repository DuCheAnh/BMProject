using BUS;
using DTO;
using System;
using System.Windows;
namespace BusinessManagement
{
    /// <summary>
    /// Interaction logic for CTHoaDon.xaml
    /// </summary>
    public partial class CTHoaDon : Window
    {
        BUS_USER user_bus = new BUS_USER();
        CTHoadonforShow cthd_ins = new CTHoadonforShow();
        Donhang dh_inst = new Donhang();
        public CTHoaDon()
        {
            InitializeComponent();
        }
        public void init_data(Donhang donhang)
        {
            //Hoadon hoadon_ins = new Hoadon();
            //hoadon_ins.DonhangID = donhang.DonhangID;
            //hoadon_ins.HoadonID = donhang.DonhangID.Replace("DH", "HD");
            dh_inst = donhang;
            cthd_ins.DonhangID = donhang.DonhangID;
            cthd_ins.HoadonID = donhang.DonhangID.Replace("DH", "HD");
            cthd_ins.ngaylap = DateTime.Now.ToString();
            cthd_ins.ngayxuat = "null";
            cthd_ins.tenkh = user_bus.getkh(donhang.KhachhangID).tenkh;
            cthd_ins.tennv = CurrentUser.nhanvien.tennv;
            cthd_ins.trigia = 1;
            foreach (CTDonhangforListing var in user_bus.transferCTDH(donhang))
            {
                cthd_ins.trigia += var.giaca * int.Parse(var.soluong);
            }
            this.DataContext = cthd_ins;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user_bus.add_newHoadon(cthd_ins.HoadonID, dh_inst.DonhangID, cthd_ins.ngaylap, cthd_ins.ngayxuat, CurrentUser.nhanvien.NVID, dh_inst.KhachhangID);
        }
    }
}
