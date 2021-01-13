namespace DTO
{
    public class Donhang
    {
        public string DonhangID { get; set; }
        public string HanghoaID { get; set; }
        public string ngaythem { get; set; }
        public string soluong { get; set; }
        public string KhachhangID { get; set; }
        public long trigia { get; set; }
        public Donhang() { }
        public Donhang(string nDonhangID, string nHanghoaID, string nNgaythem, string nSoluong, string nKhachhangID, long nTrigia)
        {
            DonhangID = nDonhangID;
            HanghoaID = nHanghoaID;
            ngaythem = nNgaythem;
            soluong = nSoluong;
            KhachhangID = nKhachhangID;
            trigia = nTrigia;
        }
    }
}
