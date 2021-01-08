namespace DTO
{
    public class Khachhang
    {
        public string KhachhangID { get; set; }
        public string tenkh { get; set; }
        public string sdt { get; set; }
        public string diachi { get; set; }
        public Khachhang()
        {
        }
        public Khachhang(string nKhachhangID, string nTenkh, string nSdt, string nDiachi)
        {
            KhachhangID = nKhachhangID;
            tenkh = nTenkh;
            sdt = nSdt;
            diachi = nDiachi;
        }
    }
}
