namespace DTO
{
    public class Donhang
    {
        public string DonhangID { get; set; }
        public string HanghoaID { get; set; }
        public string ngaythem { get; set; }
        public int soluong { get; set; }
        public string KhachhangID { get; set; }
        public Donhang() { }
        public Donhang(string nDonhangID, string nHanghoaID, string nNgaythem, int nSoluong, string nKhachhangID)
        {
            DonhangID = nDonhangID;
            HanghoaID = nHanghoaID;
            ngaythem = nNgaythem;
            soluong = nSoluong;
            KhachhangID = nKhachhangID;
        }
    }
}
