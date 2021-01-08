namespace DTO
{
    public class Hoadon
    {
        public string HoadonID { get; set; }
        public string DonhangID { get; set; }
        public string ngaylap { get; set; }
        public string ngayxuat { get; set; }
        public string NhanvienID { get; set; }
        public string KhachhangID { get; set; }
        public Hoadon() { }
        public Hoadon(string nHoadonID, string nDonhangID, string nNgaylap, string nNgayxuat, string nNhanvienID
            , string nKhachhangID)
        {
            HoadonID = nHoadonID;
            DonhangID = nDonhangID;
            ngaylap = nNgaylap;
            ngayxuat = nNgayxuat;
            NhanvienID = nNhanvienID;
            KhachhangID = nKhachhangID;
        }
    }
}
